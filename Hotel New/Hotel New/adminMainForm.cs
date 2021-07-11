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
    public partial class adminMainForm : Form
    {
        public adminMainForm()
        {
            InitializeComponent();
            sidePanel.Height = financeBtn.Height;
            sidePanel.Top = financeBtn.Top;
            adminFinanceUserControl1.BringToFront();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            //sidePanel.Height = inventoryBtn.Height;
            //sidePanel.Top = inventoryBtn.Top;

        }

        private void financeBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = financeBtn.Height;
            sidePanel.Top = financeBtn.Top;
            adminFinanceUserControl1.BringToFront();
           
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = employeeBtn.Height;
            sidePanel.Top = employeeBtn.Top;
            addEmployeeUserControl1.BringToFront();
           
            
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = customerBtn.Height;
            sidePanel.Top = customerBtn.Top;
            addCustomerUserControl1.BringToFront();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {

            sidePanel.Height = reportsBtn.Height;
            sidePanel.Top = reportsBtn.Top;
            adminReportUserControl1.BringToFront();
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = roomsBtn.Height;
            sidePanel.Top = roomsBtn.Top;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to LogOut?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result== System.Windows.Forms.DialogResult.Yes)
            {
                Welcome welcomeWindow = new Welcome();
                this.Hide();
                welcomeWindow.Visible = true;

            }
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
    }
}
