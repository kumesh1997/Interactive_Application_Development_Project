
namespace Hotel_New
{
    partial class reservationsForm
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
            this.comboRoomType = new System.Windows.Forms.ComboBox();
            this.comboRoomSize = new System.Windows.Forms.ComboBox();
            this.comboPackages = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfRooms = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scrollablePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.scrollablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboRoomType
            // 
            this.comboRoomType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoomType.FormattingEnabled = true;
            this.comboRoomType.Location = new System.Drawing.Point(22, 65);
            this.comboRoomType.Name = "comboRoomType";
            this.comboRoomType.Size = new System.Drawing.Size(159, 31);
            this.comboRoomType.TabIndex = 0;
            this.comboRoomType.Text = "Room Type";
            // 
            // comboRoomSize
            // 
            this.comboRoomSize.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboRoomSize.FormattingEnabled = true;
            this.comboRoomSize.Location = new System.Drawing.Point(22, 117);
            this.comboRoomSize.Name = "comboRoomSize";
            this.comboRoomSize.Size = new System.Drawing.Size(159, 31);
            this.comboRoomSize.TabIndex = 1;
            this.comboRoomSize.Text = "Room Size";
            // 
            // comboPackages
            // 
            this.comboPackages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPackages.FormattingEnabled = true;
            this.comboPackages.Location = new System.Drawing.Point(22, 273);
            this.comboPackages.Name = "comboPackages";
            this.comboPackages.Size = new System.Drawing.Size(159, 31);
            this.comboPackages.TabIndex = 2;
            this.comboPackages.Text = "Packages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(18, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available Number of Rooms";
            // 
            // lblNumberOfRooms
            // 
            this.lblNumberOfRooms.BackColor = System.Drawing.Color.White;
            this.lblNumberOfRooms.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNumberOfRooms.Location = new System.Drawing.Point(331, 199);
            this.lblNumberOfRooms.Name = "lblNumberOfRooms";
            this.lblNumberOfRooms.Size = new System.Drawing.Size(70, 20);
            this.lblNumberOfRooms.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 360);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.scrollablePanel);
            this.panel1.Controls.Add(this.btnReserve);
            this.panel1.Location = new System.Drawing.Point(437, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 551);
            this.panel1.TabIndex = 6;
            // 
            // scrollablePanel
            // 
            this.scrollablePanel.AutoScroll = true;
            this.scrollablePanel.BackColor = System.Drawing.Color.White;
            this.scrollablePanel.Controls.Add(this.label2);
            this.scrollablePanel.Location = new System.Drawing.Point(17, 16);
            this.scrollablePanel.Name = "scrollablePanel";
            this.scrollablePanel.Size = new System.Drawing.Size(456, 448);
            this.scrollablePanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 538);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected room with package";
            // 
            // btnReserve
            // 
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Location = new System.Drawing.Point(143, 481);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(224, 54);
            this.btnReserve.TabIndex = 2;
            this.btnReserve.Text = "Reserve!";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // reservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblNumberOfRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPackages);
            this.Controls.Add(this.comboRoomSize);
            this.Controls.Add(this.comboRoomType);
            this.Name = "reservationsForm";
            this.Size = new System.Drawing.Size(930, 555);
            this.panel1.ResumeLayout(false);
            this.scrollablePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRoomType;
        private System.Windows.Forms.ComboBox comboRoomSize;
        private System.Windows.Forms.ComboBox comboPackages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfRooms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel scrollablePanel;
    }
}
