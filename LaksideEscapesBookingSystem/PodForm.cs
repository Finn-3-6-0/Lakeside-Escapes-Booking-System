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
    public partial class PodForm : Form
    {
        public PodForm()
        {
            InitializeComponent();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            int baseCostPerNight;
            int podCapacity;

            if (!string.IsNullOrEmpty(podTypeComboBox.Text) && !string.IsNullOrEmpty(podCapacityTB.Text) && !string.IsNullOrEmpty(BaseCostPerNightTB.Text) && int.TryParse(BaseCostPerNightTB.Text, out baseCostPerNight) && int.TryParse(podCapacityTB.Text, out podCapacity))
            {
                string[] podDetails = new string[] { podIDTB.Text, podTypeComboBox.Text, podCapacity.ToString(), baseCostPerNight.ToString() };
                int rowsAffected = PodDal.AddPod(podDetails);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Pod added successfully");
                    UpdateDatabase();
                    PopulateComboBoxPodIDs();
                    podIDTB.Clear();
                    podCapacityTB.Clear();
                    podTypeTB.Clear();
                    BaseCostPerNightTB.Clear();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            else
            {
                MessageBox.Show("The criteria to add a pod has not been met, please see handbook");
            }
            
        }
        private static string _connectionstring = ConfigurationManager.ConnectionStrings["BookingSystemConnectionString"].ConnectionString;
        private void PodForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                // TODO: This line of code loads data into the 'bookingTable.Booking' table. You can move, or remove it, as needed.
                this.podTableAdapter.Fill(this.pods.Pod);
                connection.Close();
            }

            PopulateComboBoxPodIDs();
        }
        private void UpdateDatabase()
        {
            podTableAdapter.Fill(pods.Pod);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(deleteComboBox.Text))
            {
                if (MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes

                    string IdValue = deleteComboBox.SelectedItem.ToString();
                    int rowsAffected = PodDal.DeletePodByID(Convert.ToInt32(IdValue));

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pod deleted successfully");
                        UpdateDatabase();
                        PopulateComboBoxPodIDs();
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
                MessageBox.Show("select a pod to delete");
            }
           
        }

        private void PopulateComboBoxPodIDs()
        {
            // Call the method to get the items
            List<string> items = PodDal.GetPodIDs();

            // Removing "GuestID: " prefix from each string
            var formattedPodIds = items.Select(podId => podId.Replace("PodID: ", ""));

            // Clear existing items (optional)
            deleteComboBox.Items.Clear();

            // Add items to the combo box
            foreach (string item in formattedPodIds)
            {
                deleteComboBox.Items.Add(item);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 4)
            {
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 4].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int podID))
                {
                    Pods pod = PodDal.GetPodObjectByID(podID);
                    podIDTB.Text = podID.ToString();
                    podTypeComboBox.Text = pod.PodType;
                    podCapacityTB.Text = pod.Capacity;
                    BaseCostPerNightTB.Text = pod.BaseCostPerNight.ToString();
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
            if (!string.IsNullOrEmpty(podIDTB.Text))
            {
                if (!string.IsNullOrEmpty(podTypeComboBox.Text) && !string.IsNullOrEmpty(podCapacityTB.Text) && !string.IsNullOrEmpty(BaseCostPerNightTB.Text))
                {
                    string[] podDetails = new string[] { podIDTB.Text, podTypeComboBox.Text, podCapacityTB.Text, BaseCostPerNightTB.Text };

                    int rowsAffected = PodDal.UpdatePod(podDetails);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pod updated successfully");

                        UpdateDatabase();
                        PopulateComboBoxPodType();
                        podIDTB.Text = "";
                        podCapacityTB.Text = "";
                        BaseCostPerNightTB.Text = "";
                        addBTN.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("The record could not be found");
                        UpdateDatabase();
                        PopulateComboBoxPodType();
                        podIDTB.Text = "";
                        podCapacityTB.Text = "";
                        BaseCostPerNightTB.Text = "";
                        addBTN.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("The criteria to alter a pods information has not been met, please see handbook");
                }
            }
            else
            {
                MessageBox.Show("Select a pod to update");
            }
            
        }

        private void PopulateComboBoxPodType()
        {
            List<string> items = new List<string> { "Standard", "Luxury" };

            // Clear existing items (optional)
            podTypeComboBox.Items.Clear();

            // Add items to the combo box
            foreach (string item in items)
            {
                podTypeComboBox.Items.Add(item);
            }
        }
    }
}
