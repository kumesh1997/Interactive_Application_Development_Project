
namespace Hotel_New
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UsernameAdmin = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.maskedtxt_PasswordAdmin = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_ShowPasswordAdmin = new System.Windows.Forms.CheckBox();
            this.btn_SignInAdmin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_CreateAccountAdmin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 650);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 442);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGER";
            // 
            // txt_UsernameAdmin
            // 
            this.txt_UsernameAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_UsernameAdmin.BackColor = System.Drawing.Color.White;
            this.txt_UsernameAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UsernameAdmin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsernameAdmin.ForeColor = System.Drawing.Color.Silver;
            this.txt_UsernameAdmin.Location = new System.Drawing.Point(55, 74);
            this.txt_UsernameAdmin.Name = "txt_UsernameAdmin";
            this.txt_UsernameAdmin.Size = new System.Drawing.Size(194, 29);
            this.txt_UsernameAdmin.TabIndex = 1;
            this.txt_UsernameAdmin.Text = "Username";
            this.txt_UsernameAdmin.Enter += new System.EventHandler(this.usernameEnter);
            this.txt_UsernameAdmin.Leave += new System.EventHandler(this.usernameLeave);
            // 
            // maskedtxt_PasswordAdmin
            // 
            this.maskedtxt_PasswordAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedtxt_PasswordAdmin.BackColor = System.Drawing.Color.White;
            this.maskedtxt_PasswordAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedtxt_PasswordAdmin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedtxt_PasswordAdmin.ForeColor = System.Drawing.Color.Silver;
            this.maskedtxt_PasswordAdmin.Location = new System.Drawing.Point(55, 159);
            this.maskedtxt_PasswordAdmin.Name = "maskedtxt_PasswordAdmin";
            this.maskedtxt_PasswordAdmin.Size = new System.Drawing.Size(194, 29);
            this.maskedtxt_PasswordAdmin.TabIndex = 2;
            this.maskedtxt_PasswordAdmin.Text = "Password";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(51, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(453, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "_____________________________________";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "_____________________________________";
            // 
            // checkBox_ShowPasswordAdmin
            // 
            this.checkBox_ShowPasswordAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_ShowPasswordAdmin.AutoSize = true;
            this.checkBox_ShowPasswordAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.checkBox_ShowPasswordAdmin.Location = new System.Drawing.Point(55, 237);
            this.checkBox_ShowPasswordAdmin.Name = "checkBox_ShowPasswordAdmin";
            this.checkBox_ShowPasswordAdmin.Size = new System.Drawing.Size(129, 21);
            this.checkBox_ShowPasswordAdmin.TabIndex = 3;
            this.checkBox_ShowPasswordAdmin.Text = "Show Password";
            this.checkBox_ShowPasswordAdmin.UseVisualStyleBackColor = true;
            // 
            // btn_SignInAdmin
            // 
            this.btn_SignInAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SignInAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.btn_SignInAdmin.FlatAppearance.BorderSize = 2;
            this.btn_SignInAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignInAdmin.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignInAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.btn_SignInAdmin.Location = new System.Drawing.Point(389, 388);
            this.btn_SignInAdmin.Name = "btn_SignInAdmin";
            this.btn_SignInAdmin.Size = new System.Drawing.Size(449, 65);
            this.btn_SignInAdmin.TabIndex = 4;
            this.btn_SignInAdmin.Text = "&Sign In";
            this.btn_SignInAdmin.UseVisualStyleBackColor = true;
            this.btn_SignInAdmin.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.checkBox_ShowPasswordAdmin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maskedtxt_PasswordAdmin);
            this.groupBox2.Controls.Add(this.txt_UsernameAdmin);
            this.groupBox2.Location = new System.Drawing.Point(334, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 322);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btn_CreateAccountAdmin
            // 
            this.btn_CreateAccountAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CreateAccountAdmin.BackColor = System.Drawing.Color.White;
            this.btn_CreateAccountAdmin.FlatAppearance.BorderSize = 0;
            this.btn_CreateAccountAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateAccountAdmin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateAccountAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.btn_CreateAccountAdmin.Location = new System.Drawing.Point(537, 474);
            this.btn_CreateAccountAdmin.Name = "btn_CreateAccountAdmin";
            this.btn_CreateAccountAdmin.Size = new System.Drawing.Size(159, 33);
            this.btn_CreateAccountAdmin.TabIndex = 5;
            this.btn_CreateAccountAdmin.Text = "&Create Account";
            this.btn_CreateAccountAdmin.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 35);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 650);
            this.Controls.Add(this.btn_CreateAccountAdmin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_SignInAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UsernameAdmin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedtxt_PasswordAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_ShowPasswordAdmin;
        private System.Windows.Forms.Button btn_SignInAdmin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_CreateAccountAdmin;
        private System.Windows.Forms.Button btnBack;
    }
}