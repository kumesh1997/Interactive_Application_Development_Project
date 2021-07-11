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
    public partial class ReceptionistMainForm : Form
    {
        public ReceptionistMainForm()
        {
            InitializeComponent();
           
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnInvoice.Height;
            sidePanel.Top = btnInvoice.Top;
            
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnRegistration.Height;
            sidePanel.Top = btnRegistration.Top;
           
        }

        private void btnRoomsPackages_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnRoomsPackages.Height;
            sidePanel.Top = btnRoomsPackages.Top;
           
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmed_Click(object sender, EventArgs e)
        {
           
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to LogOut?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Welcome welcomeForm = new Welcome();
                this.Hide();
                welcomeForm.Visible = true;


            }
        }
    }
}
