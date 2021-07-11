
namespace Hotel_New
{
    partial class ReceptionistControlPanal
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
            this.btnPendingRecervation = new System.Windows.Forms.Button();
            this.btnConfirmedReservation = new System.Windows.Forms.Button();
            this.pendingReservationUserControl1 = new Hotel_New.pendingReservationUserControl();
            this.confirmedReservationUserControl1 = new Hotel_New.confirmedReservationUserControl();
            this.SuspendLayout();
            // 
            // btnPendingRecervation
            // 
            this.btnPendingRecervation.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingRecervation.Location = new System.Drawing.Point(0, -1);
            this.btnPendingRecervation.Name = "btnPendingRecervation";
            this.btnPendingRecervation.Size = new System.Drawing.Size(875, 65);
            this.btnPendingRecervation.TabIndex = 0;
            this.btnPendingRecervation.Text = "&Pending Reservation";
            this.btnPendingRecervation.UseVisualStyleBackColor = true;
            this.btnPendingRecervation.Click += new System.EventHandler(this.btnPendingRecervation_Click);
            // 
            // btnConfirmedReservation
            // 
            this.btnConfirmedReservation.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmedReservation.Location = new System.Drawing.Point(873, -1);
            this.btnConfirmedReservation.Name = "btnConfirmedReservation";
            this.btnConfirmedReservation.Size = new System.Drawing.Size(904, 65);
            this.btnConfirmedReservation.TabIndex = 0;
            this.btnConfirmedReservation.Text = "&Confirmed Reservation";
            this.btnConfirmedReservation.UseVisualStyleBackColor = true;
            this.btnConfirmedReservation.Click += new System.EventHandler(this.btnConfirmedReservation_Click);
            // 
            // pendingReservationUserControl1
            // 
            this.pendingReservationUserControl1.BackColor = System.Drawing.Color.White;
            this.pendingReservationUserControl1.Location = new System.Drawing.Point(4, 67);
            this.pendingReservationUserControl1.Name = "pendingReservationUserControl1";
            this.pendingReservationUserControl1.Size = new System.Drawing.Size(1860, 869);
            this.pendingReservationUserControl1.TabIndex = 1;
            // 
            // confirmedReservationUserControl1
            // 
            this.confirmedReservationUserControl1.BackColor = System.Drawing.Color.White;
            this.confirmedReservationUserControl1.Location = new System.Drawing.Point(4, 67);
            this.confirmedReservationUserControl1.Name = "confirmedReservationUserControl1";
            this.confirmedReservationUserControl1.Size = new System.Drawing.Size(1860, 866);
            this.confirmedReservationUserControl1.TabIndex = 2;
            // 
            // ReceptionistControlPanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.confirmedReservationUserControl1);
            this.Controls.Add(this.pendingReservationUserControl1);
            this.Controls.Add(this.btnConfirmedReservation);
            this.Controls.Add(this.btnPendingRecervation);
            this.Name = "ReceptionistControlPanal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1780, 936);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPendingRecervation;
        private System.Windows.Forms.Button btnConfirmedReservation;
        private pendingReservationUserControl pendingReservationUserControl1;
        private confirmedReservationUserControl confirmedReservationUserControl1;
    }
}
