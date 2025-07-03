using Microsoft.Reporting.WinForms;
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
    public partial class HubForm : Form
    {
        public HubForm()
        {
            InitializeComponent();
        }
        private static string _connectionstring = ConfigurationManager.ConnectionStrings["BookingSystemConnectionString"].ConnectionString;
        private void HubForm_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                // TODO: This line of code loads data into the 'DataSetMostPopCourses.GetMostPopularCourses' table. You can move, or remove it, as needed.
                this.GetMostPopularCoursesTableAdapter.Fill(this.DataSetMostPopCourses.GetMostPopularCourses);
                // TODO: This line of code loads data into the 'DataSetMostPopPods.GetMostPopularPods' table. You can move, or remove it, as needed.
                this.GetMostPopularPodsTableAdapter.Fill(this.DataSetMostPopPods.GetMostPopularPods);
                // TODO: This line of code loads data into the 'MostPopularPod.Booking' table. You can move, or remove it, as needed.
                this.BookingTableAdapter.Fill(this.DataSetMostPopularPod.Booking);
                //TODO
                this.CalculateMonthlyRevenue_2024TableAdapter.Fill(this.DataSetMR.CalculateMonthlyRevenue_2024);
                connection.Close();
            }


            



        
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.monthlyRevenueViewer.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
