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
    public partial class CustomerPreview : Form
    {
        public CustomerPreview()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Welcome welcomeForm = new Welcome();
            this.Hide();
            welcomeForm.Visible = true;
        }
    }
}
