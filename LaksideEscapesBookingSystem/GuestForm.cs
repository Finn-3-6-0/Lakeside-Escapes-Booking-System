using LaksideEscapesBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaksideEscapesBookingSystem
{
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }

        private void addGuestBTN_Click(object sender, EventArgs e)
        {
            string fName = firstNameTB.Text;
            string sName = lastNameTB.Text;
            string email = emailTB.Text;
            string phoneNumber = phoneNumberTB.Text;
            string title = titleComboBox.Text;
            string addressLine1 = addressLine1TB.Text;
            string addressLine2 = addressLine2TB.Text;
            string previouslyBooked = "NO";
            int rowsAffected = 0;

            if (!string.IsNullOrEmpty(fName) && !string.IsNullOrEmpty(sName) && ValidationClass.validateEmail(email) && ValidationClass.validatePhoneNumber(phoneNumber) && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(addressLine1) && !string.IsNullOrEmpty(addressLine2))
            {
                string generatedGuestID = ValidationClass.GenerateGuestID(fName, sName);
                while (!GuestDAL.IsIdUnique(generatedGuestID))
                {
                    generatedGuestID = ValidationClass.GenerateGuestID(fName, sName);
                }
                string[] guestDetails = new string[] { generatedGuestID, fName, sName, email, phoneNumber, title, addressLine1, addressLine2, previouslyBooked };
                rowsAffected = GuestDAL.AddGuest(guestDetails);

            }
            else
            {

                MessageBox.Show("The criteria to add a guest has not been met, please see handbook.");
                rowsAffected = 0;
            }
           

            if (rowsAffected > 0)
            {
                MessageBox.Show("Guest added successfully");
                UpdateDatabase();
                PopulateComboBoxGuestIDs();
                firstNameTB.Clear();
                lastNameTB.Clear();
                emailTB.Clear();
                phoneNumberTB.Clear();
                titleComboBox.Items.Clear();
                PopulateComboBox();
                addressLine1TB.Clear();
                addressLine2TB.Clear();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        
        private static string _connectionstring = ConfigurationManager.ConnectionStrings["BookingSystemConnectionString"].ConnectionString;
        private void GuestForm_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                this.guestTableAdapter2.Fill(this.guestTableDGV2.Guest);

                connection.Close();
            }


            UpdateDatabase();
            PopulateComboBoxGuestIDs();
        }
        private void PopulateComboBoxGuestIDs()
        {
            // Call the method to get the items
            List<string> items = GuestDAL.GetGuestIDs();

            // Removing "GuestID: " prefix from each string
            var formattedGuestIds = items.Select(guestId => guestId.Replace("GuestID: ", ""));

            // Clear existing items (optional)
            guestDeleteComboBox.Items.Clear();

            // Add items to the combo box
            foreach (string item in formattedGuestIds)
            {
                guestDeleteComboBox.Items.Add(item);
            }

        }

        private void UpdateDatabase()
        {
            guestTable.Clear();
            guestTableAdapter2.Fill(guestTableDGV2.Guest);
        }
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(guestDeleteComboBox.Text))
            {
                if (MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes

                    string IdValue = guestDeleteComboBox.SelectedItem.ToString();
                    int rowsAffected = GuestDAL.DeleteGuestByID(IdValue);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Guest deleted successfully");
                        UpdateDatabase();
                        PopulateComboBoxGuestIDs();
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
                MessageBox.Show("Select a guest to delete");
            }
        }
        private string guestID2;
        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guestID2))
            {
                if(!string.IsNullOrEmpty(firstNameTB.Text) && !string.IsNullOrEmpty(lastNameTB.Text) && ValidationClass.validateEmail(emailTB.Text) && ValidationClass.validatePhoneNumber(phoneNumberTB.Text) && !string.IsNullOrEmpty(titleComboBox.Text) && !string.IsNullOrEmpty(addressLine1TB.Text) && !string.IsNullOrEmpty(addressLine2TB.Text))
                {
                    string[] guestDetails = new string[] { guestID2, firstNameTB.Text, lastNameTB.Text, emailTB.Text, phoneNumberTB.Text, titleComboBox.Text, addressLine1TB.Text, addressLine2TB.Text };

                    int rowsAffected = GuestDAL.UpdateGuest(guestDetails);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Guest updated successfully");
                        UpdateDatabase();
                        firstNameTB.Clear();
                        lastNameTB.Clear();
                        emailTB.Clear();
                        phoneNumberTB.Clear();
                        PopulateComboBox();
                        addressLine1TB.Clear();
                        addressLine2TB.Clear();
                        guestID2 = "";
                        addGuestBTN.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("The record could not be found");
                        UpdateDatabase();
                        firstNameTB.Clear();
                        lastNameTB.Clear();
                        emailTB.Clear();
                        phoneNumberTB.Clear();
                        PopulateComboBox();
                        addressLine1TB.Clear();
                        addressLine2TB.Clear();
                        guestID2 = "";
                        addGuestBTN.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("The criteria to alter a guests information has not been met, please see handbook");
                }
                
            }
            else
            {
                MessageBox.Show("Select a guest to be updated");
            }
           
        }
        //OLD DGV
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 8)
            {
                object cellValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex - 8].Value;
                if (cellValue != null && cellValue is string guestID)
                {
                    Guests guest = GuestDAL.GetGuestObjectByID(guestID);
                    guestID2 = guestID;
                    firstNameTB.Text = guest.FirstName;
                    lastNameTB.Text = guest.LastName;
                    emailTB.Text = guest.Email;
                    phoneNumberTB.Text = guest.PhoneNumber;
                    titleComboBox.Text = guest.Title;
                    addressLine1TB.Text = guest.AddressLine1;
                    addressLine2TB.Text = guest.AddressLine2;
                    addGuestBTN.Enabled = false;
                }
                else
                {
                    MessageBox.Show("The cell does not contain a valid value.");
                }
            }
        }
        private void PopulateComboBox()
        {
            List<string> items = new List<string> { "Mr", "Mrs", "Ms", "Dr", "Prof", "Sir", "Lady" };

            // Clear existing items (optional)
            titleComboBox.Items.Clear();

            // Add items to the combo box
            foreach (string item in items)
            {
                titleComboBox.Items.Add(item);
            }
        }

        private void phonenumberLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
