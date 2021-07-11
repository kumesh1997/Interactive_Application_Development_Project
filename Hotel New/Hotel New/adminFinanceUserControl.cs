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
    public partial class adminFinanceUserControl : UserControl
    {
        public adminFinanceUserControl()
        {
            InitializeComponent();
            incomeUserControl1.BringToFront();
           
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            incomeUserControl1.BringToFront();
        }

        private void btnExpence_Click(object sender, EventArgs e)
        {
            expenceUserControl1.BringToFront();
        }
    }
}
