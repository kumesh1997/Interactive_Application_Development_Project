
namespace Hotel_New
{
    partial class adminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomsBtn = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.financeBtn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.adminFinanceUserControl1 = new Hotel_New.adminFinanceUserControl();
            this.adminReportUserControl1 = new Hotel_New.adminReportUserControl();
            this.addCustomerUserControl1 = new Hotel_New.addCustomerUserControl();
            this.addEmployeeUserControl1 = new Hotel_New.AddEmployeeUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.roomsBtn);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.reportsBtn);
            this.panel1.Controls.Add(this.customerBtn);
            this.panel1.Controls.Add(this.employeeBtn);
            this.panel1.Controls.Add(this.financeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1080);
            this.panel1.TabIndex = 0;
            // 
            // roomsBtn
            // 
            this.roomsBtn.FlatAppearance.BorderSize = 0;
            this.roomsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomsBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsBtn.ForeColor = System.Drawing.Color.White;
            this.roomsBtn.Location = new System.Drawing.Point(12, 441);
            this.roomsBtn.Name = "roomsBtn";
            this.roomsBtn.Size = new System.Drawing.Size(256, 70);
            this.roomsBtn.TabIndex = 3;
            this.roomsBtn.Text = "Rooms";
            this.roomsBtn.UseVisualStyleBackColor = true;
            this.roomsBtn.Click += new System.EventHandler(this.roomsBtn_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.sidePanel.Location = new System.Drawing.Point(1, 210);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 71);
            this.sidePanel.TabIndex = 1;
            // 
            // reportsBtn
            // 
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.White;
            this.reportsBtn.Location = new System.Drawing.Point(12, 517);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(256, 70);
            this.reportsBtn.TabIndex = 0;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.FlatAppearance.BorderSize = 0;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.White;
            this.customerBtn.Location = new System.Drawing.Point(12, 365);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(256, 70);
            this.customerBtn.TabIndex = 0;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.FlatAppearance.BorderSize = 0;
            this.employeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeBtn.ForeColor = System.Drawing.Color.White;
            this.employeeBtn.Location = new System.Drawing.Point(12, 288);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(256, 70);
            this.employeeBtn.TabIndex = 0;
            this.employeeBtn.Text = "Employee";
            this.employeeBtn.UseVisualStyleBackColor = true;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // financeBtn
            // 
            this.financeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.financeBtn.FlatAppearance.BorderSize = 0;
            this.financeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financeBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeBtn.ForeColor = System.Drawing.Color.White;
            this.financeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.financeBtn.Location = new System.Drawing.Point(10, 211);
            this.financeBtn.Name = "financeBtn";
            this.financeBtn.Size = new System.Drawing.Size(256, 70);
            this.financeBtn.TabIndex = 0;
            this.financeBtn.Text = "Finance";
            this.financeBtn.UseVisualStyleBackColor = false;
            this.financeBtn.Click += new System.EventHandler(this.financeBtn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1772, 82);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 44);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "    LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1650, 0);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1828, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 44);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(269, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1872, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1772, 25);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 44);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // adminFinanceUserControl1
            // 
            this.adminFinanceUserControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminFinanceUserControl1.Location = new System.Drawing.Point(268, 144);
            this.adminFinanceUserControl1.Name = "adminFinanceUserControl1";
            this.adminFinanceUserControl1.Size = new System.Drawing.Size(1776, 936);
            this.adminFinanceUserControl1.TabIndex = 6;
            // 
            // adminReportUserControl1
            // 
            this.adminReportUserControl1.Location = new System.Drawing.Point(269, 143);
            this.adminReportUserControl1.Name = "adminReportUserControl1";
            this.adminReportUserControl1.Size = new System.Drawing.Size(1776, 934);
            this.adminReportUserControl1.TabIndex = 5;
            // 
            // addCustomerUserControl1
            // 
            this.addCustomerUserControl1.Location = new System.Drawing.Point(271, 143);
            this.addCustomerUserControl1.Name = "addCustomerUserControl1";
            this.addCustomerUserControl1.Size = new System.Drawing.Size(1776, 937);
            this.addCustomerUserControl1.TabIndex = 4;
            // 
            // addEmployeeUserControl1
            // 
            this.addEmployeeUserControl1.BackColor = System.Drawing.Color.White;
            this.addEmployeeUserControl1.Location = new System.Drawing.Point(271, 145);
            this.addEmployeeUserControl1.Name = "addEmployeeUserControl1";
            this.addEmployeeUserControl1.Size = new System.Drawing.Size(1776, 935);
            this.addEmployeeUserControl1.TabIndex = 3;
            // 
            // adminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.adminFinanceUserControl1);
            this.Controls.Add(this.adminReportUserControl1);
            this.Controls.Add(this.addCustomerUserControl1);
            this.Controls.Add(this.addEmployeeUserControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Button financeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button roomsBtn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClose;
        private AddEmployeeUserControl addEmployeeUserControl1;
        private addCustomerUserControl addCustomerUserControl1;
        private adminReportUserControl adminReportUserControl1;
        private adminFinanceUserControl adminFinanceUserControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMinimize;
    }
}