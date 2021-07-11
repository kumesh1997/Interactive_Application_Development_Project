using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_New
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        adminMainForm adminForm = new adminMainForm();
        
        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm.Visible = true ;
        }

        private void usernameEnter(object sender, EventArgs e)
        {
            if (txt_UsernameAdmin.Text == "Username")
            {
                txt_UsernameAdmin.Text = " ";
                txt_UsernameAdmin.ForeColor = Color.White;
            }

        }

        private void usernameLeave(object sender, EventArgs e)
        {
            if (txt_UsernameAdmin.Text == "")
            {
                txt_UsernameAdmin.Text = "Username";
                txt_UsernameAdmin.ForeColor = Color.Silver;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Welcome welcomeForm = new Welcome();
            this.Hide();
            welcomeForm.Visible = true;
        }
    }
}
