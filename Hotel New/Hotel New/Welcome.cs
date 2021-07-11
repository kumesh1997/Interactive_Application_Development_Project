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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        Admin_Login adminLoginform = new Admin_Login() ;
        ReceptionistLogin receplogin = new ReceptionistLogin();
        CustomerPreview customerinterface = new CustomerPreview();
        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide() ;
            adminLoginform.Visible = true;
               
        }

        private void btn_closeWelcome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to quit?", "Exit Application", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_receptionist_Click(object sender, EventArgs e)
        {
            this.Hide();
            receplogin.Visible = true;
            
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerinterface.Visible = true;
        }
    }
}
