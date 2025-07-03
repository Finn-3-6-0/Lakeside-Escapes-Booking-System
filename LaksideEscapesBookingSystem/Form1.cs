using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using LaksideEscapesBookingSystem.Models;
using System.Net.Mail;
using System.Net;

namespace LaksideEscapesBookingSystem
{
    public partial class BookingMenu : Form
    {
        public BookingMenu()
        {
            InitializeComponent();

            
        }

        private void AddBookingBTN_Click(object sender, EventArgs e)
        {
            string[] bookingInfo = new string[12];

            string errorMessage = ValidationClass.errorBuilderBookingForm(guestIDComboBox.Text, podIDComboBox.Text, courseIDComboBox.Text, noOfOccupantsTB.Text);

            if(errorMessage.Contains("not"))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                if (ValidationClass.bookedInAdvance(bookingDateTimePicker.Value, bookingDateTimePicker.Value.AddDays(Convert.ToInt32(noOfDaysComboBox.SelectedItem))) && BookingDal.DoesBookingOverlap(podIDComboBox.Text, bookingDateTimePicker.Value, bookingDateTimePicker.Value.AddDays(Convert.ToInt32(noOfDaysComboBox.SelectedItem)), 0) && !BookingDal.DoesNoOccsExceedCapacity(Convert.ToInt32(podIDComboBox.Text), Convert.ToInt32(noOfOccupantsTB.Text)))
                {
                    //No validation required can be any selected value
                    bookingInfo[0] = "";
                    bookingInfo[1] = guestIDComboBox.Text;
                    bookingInfo[2] = podIDComboBox.Text;
                    bookingInfo[3] = courseIDComboBox.Text;

                   //Must not exceed pod capacity (Handled in above if statement)
                    bookingInfo[4] = noOfOccupantsTB.Text;                                  
                    
                    //Has to be booked in advance and cant overlap (Handled in if statement)
                    bookingInfo[5] = bookingDateTimePicker.Value.ToString();
                    bookingInfo[6] = bookingDateTimePicker.Value.AddDays(Convert.ToInt32(noOfDaysComboBox.SelectedItem)).ToString();

                    //No validation needed default value
                    bookingInfo[7] = "Provisional";

                    //Needed to calculate deposit
                    int selectedNumberOfDays = Convert.ToInt32(noOfDaysComboBox.SelectedItem);

                    //Deposit calculation
                    bookingInfo[8] = ValidationClass.calculateDeposit(Convert.ToInt32(podIDComboBox.Text), Convert.ToInt32(courseIDComboBox.Text), Convert.ToInt32(noOfOccupantsTB.Text), selectedNumberOfDays);

                    //Discount calculation
                    bookingInfo[9] = ValidationClass.calculateDiscount(guestIDComboBox.Text.Substring(0, 5), bookingDateTimePicker.Value);

                    //Total claculation
                    bookingInfo[10] = ValidationClass.calculateTotal(Convert.ToInt32(podIDComboBox.Text), Convert.ToInt32(courseIDComboBox.Text), Convert.ToInt32(noOfOccupantsTB.Text), selectedNumberOfDays);
                    
                    //No validation needed is default value of today
                    bookingInfo[11] = DateTime.Now.ToString();
                    
                    int rowsAffected = BookingDal.AddBooking(bookingInfo);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking added successfully");
                        UpdateDatabase();
                        PopulateComboBoxBookingsForDelete();
                        PopulateComboBoxGuestIDs();
                        PopulateComboBoxBookings();
                        PopulateComboBoxNoOfDays();
                        PopulateComboBoxCourse();
                        PopulateComboBoxPods();
                        noOfOccupantsTB.Text = "";
                        bookingDateTimePicker.Value = DateTime.Now;
                        previewBookinglbl.Text = "";
                        previewBookinglbl2.Text = "";
                        previewBookinglbl3.Text = "";
                        podIDTB.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Fail");
                        UpdateDatabase();
                        PopulateComboBoxBookingsForDelete();
                        PopulateComboBoxGuestIDs();
                        PopulateComboBoxBookings();
                        PopulateComboBoxNoOfDays();
                        PopulateComboBoxCourse();
                        PopulateComboBoxPods();
                        noOfOccupantsTB.Text = "";
                        bookingDateTimePicker.Value = DateTime.Now;
                        previewBookinglbl.Text = "";
                        previewBookinglbl2.Text = "";
                        previewBookinglbl3.Text = "";
                        podIDTB.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("The criteria to add a booking has not been met, please see handbook.");
                }
            }         
        }
        

        static string ExtractNumber(string input)
        {
            string substringToRemove = "BookingID: ";
            string result = input.Replace(substringToRemove, "");
            Convert.ToInt32(result);

            return result;
        }
        //Pay deposit btn
        private void button1_Click(object sender, EventArgs e)
        {
            //Pay selected guests deposit making their booking permanent

            if (!string.IsNullOrEmpty(bookingIDComboBox.Text))
            {
                string IdValue = bookingIDComboBox.SelectedItem.ToString();
                string numberString = ExtractNumber(IdValue);
                int id = Convert.ToInt32(numberString);


                DateTime dateBooked = BookingDal.getDateBooked(id);


                if (ValidationClass.canBookingBeMadePermanent(dateBooked))
                {
                    BookingDal.UpdateBookingStatusToPermanent(id);
                    MessageBox.Show("Booking is now permanent");
                    UpdateDatabase();
                    PopulateComboBoxBookings();                 
                }
                else
                {
                    MessageBox.Show("Booking is not availbe to be made permanent or is already permanent");
                }
            }
            else
            {
                MessageBox.Show("Select a booking to be made permanent");
            }

            
            /*
            //OLD VIEW GUEST AS A LIST

            //format string to just a number 
            //BookingID: 1

            string IdValue = bookingIDComboBox.SelectedItem.ToString();
            string numberString = ExtractNumber(IdValue);

            List<string> bookings = BookingDal.GetBookingsByBookingID(Convert.ToInt32(numberString));

            if (bookings.Count >= 1)
            {
                StringBuilder sb = new StringBuilder();

                foreach(string booking in bookings)
                {
                    sb.AppendLine(booking);
                }

                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show("There are no bookings by that id");
            }

            */
        }

        private void bookingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }
        private static string _connectionstring = ConfigurationManager.ConnectionStrings["BookingSystemConnectionString"].ConnectionString;
        private void BookingMenu_Load(object sender, EventArgs e)
        {
            //Method called to delete bookings that have not been made permanent in time
            BookingDal.DeleteExpiredBookings();

            //Populates DGV
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                // TODO: This line of code loads data into the 'updatedBookingTable.Booking' table. You can move, or remove it, as needed.
                this.bookingTableAdapter1.Fill(this.updatedBookingTable.Booking);
                connection.Close();
            }


            //Populates combo boxes
            PopulateComboBoxBookings();
            PopulateComboBoxCourse();
            PopulateComboBoxPods();
            PopulateComboBoxGuestIDs();
            PopulateComboBoxBookingsForDelete();
        }
        private void UpdateDatabase()
        {
            bookingTableAdapter1.Fill(updatedBookingTable.Booking);
        }
        private void PopulateComboBoxGuestIDs()
        {
            // Call the method to get the items
            List<string> items = GuestDAL.GetGuestIDs();

            // Removing "PodID: " prefix from each string
            var formattedGuestIds = items.Select(guestId => guestId.Replace("GuestID: ", ""));

            // Clear existing items (optional)
            guestIDComboBox.Items.Clear();

            // Add items to the combo box
            foreach (string item in formattedGuestIds)
            {
                guestIDComboBox.Items.Add(item);
            }

        }
        private void PopulateComboBoxBookingsForDelete()
        {
            // Call the method to get the items
            List<string> items = BookingDal.GetBookingsIDs();

            // Clear existing items (optional)
            bookingIDsDeleteComboBox.Items.Clear();

            // Add items to the combo box
            foreach (string item in items)
            {
                bookingIDsDeleteComboBox.Items.Add(item);
            }

           
        }
        private void PopulateComboBoxBookings()
        {
            // Call the method to get the items
            List<string> items = BookingDal.GetBookingsIDs();

            // Clear existing items (optional)
            bookingIDComboBox.Items.Clear();

            // Add items to the combo box
            foreach (string item in items)
            {
                bookingIDComboBox.Items.Add(item);
            }

           
        }
        private void PopulateComboBoxCourse()
        {
            List<string> items2 = CourseDal.GetCourseIDs();

            // Clear existing items (optional)
            courseIDComboBox.Items.Clear();

            // Removing "PodID: " prefix from each string
            var formattedCourseIds = items2.Select(courseId => courseId.Replace("CourseID: ", ""));

            // Add items to the combo box
            foreach (string item in formattedCourseIds)
            {
                courseIDComboBox.Items.Add(item);
            }

           
        }

        private void PopulateComboBoxPods()
        {
            List<string> items3 = PodDal.GetPodIDs();

            // Clear existing items (optional)
            podIDComboBox.Items.Clear();

            // Removing "PodID: " prefix from each string
            var formattedPodIds = items3.Select(podId => podId.Replace("PodID: ", ""));

            // Add items to the combo box
            foreach (string item in formattedPodIds)
            {
                podIDComboBox.Items.Add(item);
            }

            
        }

        private void PopulateComboBoxNoOfDays()
        {
            List<string> items = new List<string> { "3", "5", "7", "14" };

            // Clear existing items (optional)
            noOfDaysComboBox.Items.Clear();

            // Add items to the combo box
            foreach (string item in items)
            {
                noOfDaysComboBox.Items.Add(item);
            }
        }
        private void bookingIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 12)
            {
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 12].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int bookingID))
                {
                    Bookings booking = BookingDal.GetBookingObjectByID(bookingID);
                    podIDTB.Text = bookingID.ToString();
                    noOfDaysComboBox.Text = ValidationClass.guestLengthOfStay(booking.CheckInDate, booking.CheckOutDate).ToString();
                    bookingDateTimePicker.Value = booking.CheckInDate;
                    guestIDComboBox.Text = booking.GuestID;
                    podIDComboBox.Text = booking.PodID.ToString();
                    courseIDComboBox.Text = booking.CourseID.ToString();
                    noOfOccupantsTB.Text = booking.NumberOfOccupants.ToString();
                    AddBookingBTN.Enabled = false;
                }
                else
                {
                    MessageBox.Show("The cell does not contain a valid integer value.");
                }
            }
        }
        //delete button
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bookingIDsDeleteComboBox.Text))
            {
                if (MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    string IdValue = bookingIDsDeleteComboBox.SelectedItem.ToString();
                    string numberString = ExtractNumber(IdValue);

                    int rowsAffected = BookingDal.DeleteBookingByID(Convert.ToInt32(numberString));

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking deleted successfully");
                        UpdateDatabase();
                        PopulateComboBoxBookingsForDelete();
                        PopulateComboBoxBookings();
                    }
                    else
                    {
                        MessageBox.Show("Failed delete");
                    }
                }
                else
                {
                    // user clicked no
                    MessageBox.Show("Delete cancelled");
                }
            }
            else
            {
                MessageBox.Show("Select a booking to delete");
            }
        }

        private void guestIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            previewBookinglbl.Text = "";
            var items = GuestDAL.GetGuestByGuestID(guestIDComboBox.SelectedItem.ToString());
            for (int i = 0; i < items.Count; i++)
            {
                previewBookinglbl.Text += items.ElementAt(i);
            }
 
        }

        private void podIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            previewBookinglbl3.Text = "";
            var items = PodDal.GetPodsByPodID(Convert.ToInt32(podIDComboBox.SelectedItem));
            for (int i = 0; i < items.Count; i++)
            {
                previewBookinglbl3.Text += items.ElementAt(i);
            }
        }

        private void courseIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            previewBookinglbl2.Text = "";
            var items = CourseDal.GetCoursesByCourseID(Convert.ToInt32(courseIDComboBox.SelectedItem));
            for (int i = 0; i < items.Count; i++)
            {
                previewBookinglbl2.Text += items.ElementAt(i);
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(podIDTB.Text))
            {
                string[] bookingInfo = new string[12];

                if (ValidationClass.bookedInAdvance(bookingDateTimePicker.Value, bookingDateTimePicker.Value.AddDays(Convert.ToInt32(noOfDaysComboBox.SelectedItem))) && BookingDal.DoesBookingOverlap(podIDComboBox.Text, bookingDateTimePicker.Value, bookingDateTimePicker.Value.AddDays(Convert.ToInt32(noOfDaysComboBox.SelectedItem)), Convert.ToInt32(podIDTB.Text)) && !BookingDal.DoesNoOccsExceedCapacity(Convert.ToInt32(podIDComboBox.Text), Convert.ToInt32(noOfOccupantsTB.Text)))
                {
                    //Validation not needed can be any selected value
                    bookingInfo[0] = podIDTB.Text;
                    bookingInfo[1] = guestIDComboBox.Text;
                    bookingInfo[2] = podIDComboBox.Text;
                    bookingInfo[3] = courseIDComboBox.Text;

                    //Must not exceed pod capacity (Handled in above if statement)
                    bookingInfo[4] = noOfOccupantsTB.Text;

                    //Has to be booked in advance and cant overlap (Handled in if statement)
                    bookingInfo[5] = bookingDateTimePicker.Value.ToString();
                    bookingInfo[6] = bookingDateTimePicker.Value.AddDays(Convert.ToInt32(noOfDaysComboBox.SelectedItem)).ToString();

                    //No validation needed default value
                    bookingInfo[7] = "Provisional";

                    //Needed to calculate deposit
                    int selectedNumberOfDays = Convert.ToInt32(noOfDaysComboBox.SelectedItem);

                    //Deposit calculation
                    bookingInfo[8] = ValidationClass.calculateDeposit(Convert.ToInt32(podIDComboBox.Text), Convert.ToInt32(courseIDComboBox.Text), Convert.ToInt32(noOfOccupantsTB.Text), selectedNumberOfDays);

                    //Discount calculation
                    bookingInfo[9] = ValidationClass.calculateDiscount(guestIDComboBox.Text.Substring(0, 5), bookingDateTimePicker.Value);

                    //Total claculation
                    bookingInfo[10] = ValidationClass.calculateTotal(Convert.ToInt32(podIDComboBox.Text), Convert.ToInt32(courseIDComboBox.Text), Convert.ToInt32(noOfOccupantsTB.Text), selectedNumberOfDays);
                    bookingInfo[11] = DateTime.Now.ToString();
                    int rowsAffected = BookingDal.UpdateBooking(bookingInfo);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking updated successfully");
                        UpdateDatabase();
                        PopulateComboBoxNoOfDays();
                        PopulateComboBoxGuestIDs();
                        PopulateComboBoxCourse();
                        PopulateComboBoxPods();
                        noOfOccupantsTB.Text = "";
                        bookingDateTimePicker.Value = DateTime.Now;
                        previewBookinglbl.Text = "";
                        previewBookinglbl2.Text = "";
                        previewBookinglbl3.Text = "";
                        podIDTB.Text = "";
                        AddBookingBTN.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("The record could not be found");
                        UpdateDatabase();
                        PopulateComboBoxNoOfDays();
                        PopulateComboBoxGuestIDs();
                        PopulateComboBoxCourse();
                        PopulateComboBoxPods();
                        noOfOccupantsTB.Text = "";
                        bookingDateTimePicker.Value = DateTime.Now;
                        previewBookinglbl.Text = "";
                        previewBookinglbl2.Text = "";
                        previewBookinglbl3.Text = "";
                        podIDTB.Text = "";
                        AddBookingBTN.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("The criteria to update a booking has not been met, please see handbook");
                }
            }
            else
            {
                MessageBox.Show("Select a booking to update");
            }

            
        }

        private void previewBookinglbl2_Click(object sender, EventArgs e)
        {

        }

        private void bookingIDsDeleteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
