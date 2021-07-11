
namespace Hotel_New
{
    partial class ReceptionistMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRoomsPackages = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnConfirmed = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.receptionistControlPanal1 = new Hotel_New.ReceptionistControlPanal();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRoomsPackages);
            this.panel1.Controls.Add(this.btnRegistration);
            this.panel1.Controls.Add(this.btnInvoice);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1080);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(272, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 100);
            this.panel2.TabIndex = 3;
            // 
            // btnRoomsPackages
            // 
            this.btnRoomsPackages.FlatAppearance.BorderSize = 0;
            this.btnRoomsPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomsPackages.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomsPackages.ForeColor = System.Drawing.Color.White;
            this.btnRoomsPackages.Location = new System.Drawing.Point(11, 439);
            this.btnRoomsPackages.Name = "btnRoomsPackages";
            this.btnRoomsPackages.Size = new System.Drawing.Size(256, 70);
            this.btnRoomsPackages.TabIndex = 0;
            this.btnRoomsPackages.Text = "&Room && Packages";
            this.btnRoomsPackages.UseVisualStyleBackColor = true;
            this.btnRoomsPackages.Click += new System.EventHandler(this.btnRoomsPackages_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.Location = new System.Drawing.Point(11, 363);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(256, 70);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "&Customer";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Location = new System.Drawing.Point(11, 287);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(256, 70);
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.Text = "&Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.sidePanel.Location = new System.Drawing.Point(1, 210);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 71);
            this.sidePanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1650, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnPending
            // 
            this.btnPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.btnPending.FlatAppearance.BorderSize = 3;
            this.btnPending.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.ForeColor = System.Drawing.Color.White;
            this.btnPending.Location = new System.Drawing.Point(923, 363);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(84, 63);
            this.btnPending.TabIndex = 3;
            this.btnPending.Text = "&Pending Reservation";
            this.btnPending.UseVisualStyleBackColor = false;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnConfirmed
            // 
            this.btnConfirmed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.btnConfirmed.FlatAppearance.BorderSize = 3;
            this.btnConfirmed.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmed.ForeColor = System.Drawing.Color.White;
            this.btnConfirmed.Location = new System.Drawing.Point(923, 287);
            this.btnConfirmed.Name = "btnConfirmed";
            this.btnConfirmed.Size = new System.Drawing.Size(63, 63);
            this.btnConfirmed.TabIndex = 3;
            this.btnConfirmed.Text = "&Confirmed Reservation";
            this.btnConfirmed.UseVisualStyleBackColor = false;
            this.btnConfirmed.Click += new System.EventHandler(this.btnConfirmed_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.btnViewAll.FlatAppearance.BorderSize = 3;
            this.btnViewAll.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(923, 432);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(108, 63);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "&View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1801, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1703, 22);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 37);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1561, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 37);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "     Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // receptionistControlPanal1
            // 
            this.receptionistControlPanal1.BackColor = System.Drawing.Color.White;
            this.receptionistControlPanal1.Location = new System.Drawing.Point(270, 146);
            this.receptionistControlPanal1.Name = "receptionistControlPanal1";
            this.receptionistControlPanal1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.receptionistControlPanal1.Size = new System.Drawing.Size(1780, 936);
            this.receptionistControlPanal1.TabIndex = 10;
            // 
            // ReceptionistMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.receptionistControlPanal1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnConfirmed);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionistMainForm";
            this.Text = "ReceptionistMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRoomsPackages;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnConfirmed;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnLogout;
        private ReceptionistControlPanal receptionistControlPanal1;
    }
}