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
    public partial class pendingReservationUserControl : UserControl
    {
        public pendingReservationUserControl()
        {
            InitializeComponent();
            viewAllUserControl1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewAllUserControl1.Visible = true;
            viewAllUserControl1.BringToFront();
        }
    }
}
