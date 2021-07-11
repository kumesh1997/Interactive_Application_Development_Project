
namespace Hotel_New
{
    partial class AddInventoryUserControl
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
            this.itemCodeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemCodeCombo = new System.Windows.Forms.ComboBox();
            this.itemCategoryCombo = new System.Windows.Forms.ComboBox();
            this.itemPriceText = new System.Windows.Forms.TextBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.supplierCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // itemCodeText
            // 
            this.itemCodeText.AutoSize = true;
            this.itemCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCodeText.Location = new System.Drawing.Point(111, 44);
            this.itemCodeText.Name = "itemCodeText";
            this.itemCodeText.Size = new System.Drawing.Size(96, 24);
            this.itemCodeText.TabIndex = 0;
            this.itemCodeText.Text = "Item Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unit Price (Rs.) ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quntity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Supplier";
            // 
            // itemCodeCombo
            // 
            this.itemCodeCombo.FormattingEnabled = true;
            this.itemCodeCombo.Location = new System.Drawing.Point(295, 42);
            this.itemCodeCombo.Name = "itemCodeCombo";
            this.itemCodeCombo.Size = new System.Drawing.Size(279, 24);
            this.itemCodeCombo.TabIndex = 1;
            // 
            // itemCategoryCombo
            // 
            this.itemCategoryCombo.FormattingEnabled = true;
            this.itemCategoryCombo.Location = new System.Drawing.Point(295, 100);
            this.itemCategoryCombo.Name = "itemCategoryCombo";
            this.itemCategoryCombo.Size = new System.Drawing.Size(279, 24);
            this.itemCategoryCombo.TabIndex = 1;
            // 
            // itemPriceText
            // 
            this.itemPriceText.Location = new System.Drawing.Point(295, 148);
            this.itemPriceText.Name = "itemPriceText";
            this.itemPriceText.Size = new System.Drawing.Size(279, 22);
            this.itemPriceText.TabIndex = 2;
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(295, 201);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(279, 22);
            this.quantityText.TabIndex = 2;
            // 
            // supplierCombo
            // 
            this.supplierCombo.FormattingEnabled = true;
            this.supplierCombo.Location = new System.Drawing.Point(295, 254);
            this.supplierCombo.Name = "supplierCombo";
            this.supplierCombo.Size = new System.Drawing.Size(279, 24);
            this.supplierCombo.TabIndex = 3;
            // 
            // AddInventoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.supplierCombo);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.itemPriceText);
            this.Controls.Add(this.itemCategoryCombo);
            this.Controls.Add(this.itemCodeCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemCodeText);
            this.Name = "AddInventoryUserControl";
            this.Size = new System.Drawing.Size(931, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemCodeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox itemCodeCombo;
        private System.Windows.Forms.ComboBox itemCategoryCombo;
        private System.Windows.Forms.TextBox itemPriceText;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.ComboBox supplierCombo;
    }
}
