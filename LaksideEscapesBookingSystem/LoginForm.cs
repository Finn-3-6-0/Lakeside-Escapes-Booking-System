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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblLoginSubmit_Click(object sender, EventArgs e)
        {
            if (txtbLogin.Text == "" && txtbPassword.Text == "")
            {
                
                //if admin credentials 
                //set a static bool to true if yes then can acces the add, edit and delete pod and course methods
            }



        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            BookingViewer b = new BookingViewer();
            b.Show();

        }
    }
}
