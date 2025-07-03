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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }
        private void UpdateDatabase()
        {
            courseTableAdapter.Fill(courses.Course);
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            int courseCostPerPerson;
            if (!string.IsNullOrEmpty(courseNameTB.Text) && !string.IsNullOrEmpty(corseCostPerPersonTB.Text) && int.TryParse(corseCostPerPersonTB.Text, out courseCostPerPerson))
            {
                string[] courseDetails = new string[] { courseIDTB.Text, courseNameTB.Text, courseCostPerPerson .ToString()};

                int rowsAffected = CourseDal.AddCourse(courseDetails);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course added successfully");
                    UpdateDatabase();
                    PopulateComboBoxCourseIDs();
                    courseNameTB.Clear();
                    courseIDTB.Clear();
                    corseCostPerPersonTB.Clear();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            else
            {
                MessageBox.Show("The criteria to add a course has not been met, please see handbook.");
            }
            
        }
        private static string _connectionstring = ConfigurationManager.ConnectionStrings["BookingSystemConnectionString"].ConnectionString;
        private void CourseForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                // TODO: This line of code loads data into the 'bookingTable.Booking' table. You can move, or remove it, as needed.
                this.courseTableAdapter.Fill(this.courses.Course);
                connection.Close();
            }
            PopulateComboBoxCourseIDs();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(deleteComboBox.Text))
            {
                if (MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes

                    string IdValue = deleteComboBox.SelectedItem.ToString();
                    int rowsAffected = CourseDal.DeleteCourseByID(Convert.ToInt32(IdValue));

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course deleted successfully");
                        UpdateDatabase();
                        PopulateComboBoxCourseIDs();
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
                MessageBox.Show("Select a course to delete");
            }
            
        }

        private void PopulateComboBoxCourseIDs()
        {
            // Call the method to get the items
            List<string> items = CourseDal.GetCourseIDs();

            // Removing "GuestID: " prefix from each string
            var formattedCourseIds = items.Select(courseId => courseId.Replace("CourseID: ", ""));

            // Clear existing items (optional)
            deleteComboBox.Items.Clear();

            // Add items to the combo box
            foreach (string item in formattedCourseIds)
            {
                deleteComboBox.Items.Add(item);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 3)
            {
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 3].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int courseID))
                {
                    Courses course = CourseDal.GetCourseObjectByID(courseID);
                    courseIDTB.Text = courseID.ToString();
                    courseNameTB.Text = course.CourseName.ToString();
                    corseCostPerPersonTB.Text = course.CourseCostPerPerson.ToString();
                    addBTN.Enabled = false;
                }
                else
                {
                    MessageBox.Show("The cell does not contain a valid integer value.");
                }
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(courseIDTB.Text))
            {
                if (!string.IsNullOrEmpty(courseNameTB.Text) && !string.IsNullOrEmpty(corseCostPerPersonTB.Text))
                {
                    string[] courseDetails = new string[] { courseIDTB.Text, courseNameTB.Text, corseCostPerPersonTB.Text };

                    int rowsAffected = CourseDal.UpdateCourse(courseDetails);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course updated successfully");
                        UpdateDatabase();
                        PopulateComboBoxCourseIDs();
                        courseNameTB.Clear();
                        courseIDTB.Clear();
                        corseCostPerPersonTB.Clear();
                        addBTN.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("The record could not be found");
                        UpdateDatabase();
                        PopulateComboBoxCourseIDs();
                        courseNameTB.Clear();
                        courseIDTB.Clear();
                        corseCostPerPersonTB.Clear();
                        addBTN.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("The criteria to alter a courses information has not been met, please see handbook");
                }
               
            }
            else
            {
                MessageBox.Show("Select a course to update");
            }
            
        }
    }
}
