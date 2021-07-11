
namespace Hotel_New
{
    partial class adminReportUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMonthlyTrend = new System.Windows.Forms.Button();
            this.btnMonthlyIncome = new System.Windows.Forms.Button();
            this.btnMonthlyRev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMonthlyTrend);
            this.panel1.Controls.Add(this.btnMonthlyIncome);
            this.panel1.Controls.Add(this.btnMonthlyRev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1776, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnMonthlyTrend
            // 
            this.btnMonthlyTrend.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyTrend.Location = new System.Drawing.Point(705, 0);
            this.btnMonthlyTrend.Name = "btnMonthlyTrend";
            this.btnMonthlyTrend.Size = new System.Drawing.Size(355, 101);
            this.btnMonthlyTrend.TabIndex = 0;
            this.btnMonthlyTrend.Text = "Monthly Trend";
            this.btnMonthlyTrend.UseVisualStyleBackColor = true;
            // 
            // btnMonthlyIncome
            // 
            this.btnMonthlyIncome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyIncome.Location = new System.Drawing.Point(353, 0);
            this.btnMonthlyIncome.Name = "btnMonthlyIncome";
            this.btnMonthlyIncome.Size = new System.Drawing.Size(355, 101);
            this.btnMonthlyIncome.TabIndex = 0;
            this.btnMonthlyIncome.Text = "Monthly Income";
            this.btnMonthlyIncome.UseVisualStyleBackColor = true;
            // 
            // btnMonthlyRev
            // 
            this.btnMonthlyRev.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyRev.Location = new System.Drawing.Point(0, 0);
            this.btnMonthlyRev.Name = "btnMonthlyRev";
            this.btnMonthlyRev.Size = new System.Drawing.Size(355, 101);
            this.btnMonthlyRev.TabIndex = 0;
            this.btnMonthlyRev.Text = "Monthly Revenue";
            this.btnMonthlyRev.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1058, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "All Expenses";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1411, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(377, 101);
            this.button2.TabIndex = 0;
            this.button2.Text = "All Income";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // adminReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "adminReportUserControl";
            this.Size = new System.Drawing.Size(1776, 883);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMonthlyTrend;
        private System.Windows.Forms.Button btnMonthlyIncome;
        private System.Windows.Forms.Button btnMonthlyRev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
