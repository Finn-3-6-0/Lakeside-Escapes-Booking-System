using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaksideEscapesBookingSystem
{
    public partial class BookingViewer : Form
    {
        public BookingViewer()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new GuestForm());
        }

        private void podFormBTN_Click(object sender, EventArgs e)
        {
            loadform(new PodForm());
        }

        private void bookingFormBTN_Click(object sender, EventArgs e)
        {
            loadform(new BookingMenu());
        }

        private void courseFormBTN_Click(object sender, EventArgs e)
        {
            loadform(new CourseForm());
        }

        private void hubFormBTN_Click(object sender, EventArgs e)
        {
            loadform(new HubForm());
        }

        private void closeProgramLBL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
