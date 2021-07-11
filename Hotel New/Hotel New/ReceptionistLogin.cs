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
    public partial class ReceptionistLogin : Form
    {
        public ReceptionistLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Welcome welcomeForm = new Welcome();
            this.Hide();
            welcomeForm.Visible = true;
        }

        private void btn_SignInRecep_Click(object sender, EventArgs e)
        {
            ReceptionistMainForm receptionistForm = new ReceptionistMainForm();
            this.Hide();
            receptionistForm.Visible = true;

        }
    }
}
