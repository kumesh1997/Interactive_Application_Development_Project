
namespace Hotel_New
{
    partial class viewAllUserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nicNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nicNumber,
            this.roomNumber,
            this.roomType,
            this.roomSize,
            this.bookingDate,
            this.checkinDate,
            this.checkoutDate,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(317, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 525);
            this.dataGridView1.TabIndex = 0;
            // 
            // nicNumber
            // 
            this.nicNumber.HeaderText = "NIC Number";
            this.nicNumber.MinimumWidth = 6;
            this.nicNumber.Name = "nicNumber";
            this.nicNumber.Width = 125;
            // 
            // roomNumber
            // 
            this.roomNumber.HeaderText = "Room Number";
            this.roomNumber.MinimumWidth = 6;
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Width = 125;
            // 
            // roomType
            // 
            this.roomType.HeaderText = "Room Type";
            this.roomType.MinimumWidth = 6;
            this.roomType.Name = "roomType";
            this.roomType.Width = 125;
            // 
            // roomSize
            // 
            this.roomSize.HeaderText = "Room Size";
            this.roomSize.MinimumWidth = 6;
            this.roomSize.Name = "roomSize";
            this.roomSize.Width = 125;
            // 
            // bookingDate
            // 
            this.bookingDate.HeaderText = "Booking Date";
            this.bookingDate.MinimumWidth = 6;
            this.bookingDate.Name = "bookingDate";
            this.bookingDate.Width = 125;
            // 
            // checkinDate
            // 
            this.checkinDate.HeaderText = "Check-in Date";
            this.checkinDate.MinimumWidth = 6;
            this.checkinDate.Name = "checkinDate";
            this.checkinDate.Width = 125;
            // 
            // checkoutDate
            // 
            this.checkoutDate.HeaderText = "Check-out Date";
            this.checkoutDate.MinimumWidth = 6;
            this.checkoutDate.Name = "checkoutDate";
            this.checkoutDate.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(317, 739);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 45);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // viewAllUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewAllUserControl";
            this.Size = new System.Drawing.Size(1860, 856);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.Button btnBack;
    }
}
