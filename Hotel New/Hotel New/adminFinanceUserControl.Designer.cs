
namespace Hotel_New
{
    partial class adminFinanceUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnExpence = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.incomeUserControl1 = new Hotel_New.incomeUserControl();
            this.expenceUserControl1 = new Hotel_New.expenceUserControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(92)))));
            this.btnIncome.FlatAppearance.BorderSize = 3;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.Location = new System.Drawing.Point(1, 0);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(888, 64);
            this.btnIncome.TabIndex = 0;
            this.btnIncome.Text = "&Income";
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnExpence
            // 
            this.btnExpence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(92)))));
            this.btnExpence.FlatAppearance.BorderSize = 3;
            this.btnExpence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpence.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpence.ForeColor = System.Drawing.Color.White;
            this.btnExpence.Location = new System.Drawing.Point(887, -1);
            this.btnExpence.Name = "btnExpence";
            this.btnExpence.Size = new System.Drawing.Size(888, 64);
            this.btnExpence.TabIndex = 0;
            this.btnExpence.Text = "&Expenses";
            this.btnExpence.UseVisualStyleBackColor = false;
            this.btnExpence.Click += new System.EventHandler(this.btnExpence_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExpence);
            this.panel1.Controls.Add(this.btnIncome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1776, 66);
            this.panel1.TabIndex = 0;
            // 
            // incomeUserControl1
            // 
            this.incomeUserControl1.BackColor = System.Drawing.Color.White;
            this.incomeUserControl1.Location = new System.Drawing.Point(4, 65);
            this.incomeUserControl1.Name = "incomeUserControl1";
            this.incomeUserControl1.Size = new System.Drawing.Size(1653, 837);
            this.incomeUserControl1.TabIndex = 3;
            // 
            // expenceUserControl1
            // 
            this.expenceUserControl1.BackColor = System.Drawing.Color.White;
            this.expenceUserControl1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenceUserControl1.Location = new System.Drawing.Point(3, 64);
            this.expenceUserControl1.Name = "expenceUserControl1";
            this.expenceUserControl1.Size = new System.Drawing.Size(1776, 871);
            this.expenceUserControl1.TabIndex = 2;
            // 
            // adminFinanceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incomeUserControl1);
            this.Controls.Add(this.expenceUserControl1);
            this.Controls.Add(this.panel1);
            this.Name = "adminFinanceUserControl";
            this.Size = new System.Drawing.Size(1776, 883);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private expenceUserControl expenceUserControl1;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnExpence;
        private System.Windows.Forms.Panel panel1;
        private incomeUserControl incomeUserControl1;
    }
}
