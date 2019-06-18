namespace UI.Views.Product
{
    partial class AddProductToReceiptView
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAddToReceipt = new System.Windows.Forms.Button();
            this.lblQunatity = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNameHeading = new System.Windows.Forms.Label();
            this.lblPriceHeading = new System.Windows.Forms.Label();
            this.lblDiscountHeading = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(44, 152);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(202, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToReceipt
            // 
            this.btnAddToReceipt.Location = new System.Drawing.Point(44, 190);
            this.btnAddToReceipt.Name = "btnAddToReceipt";
            this.btnAddToReceipt.Size = new System.Drawing.Size(202, 33);
            this.btnAddToReceipt.TabIndex = 1;
            this.btnAddToReceipt.Text = "Dodaj na račun";
            this.btnAddToReceipt.UseVisualStyleBackColor = true;
            this.btnAddToReceipt.Click += new System.EventHandler(this.btnAddToReceipt_Click);
            // 
            // lblQunatity
            // 
            this.lblQunatity.AutoSize = true;
            this.lblQunatity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQunatity.Location = new System.Drawing.Point(74, 116);
            this.lblQunatity.Name = "lblQunatity";
            this.lblQunatity.Size = new System.Drawing.Size(127, 20);
            this.lblQunatity.TabIndex = 2;
            this.lblQunatity.Text = "Izaberite količinu";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblDiscountHeading, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPriceHeading, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNameHeading, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDiscount, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 72);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblNameHeading
            // 
            this.lblNameHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameHeading.AutoSize = true;
            this.lblNameHeading.Location = new System.Drawing.Point(26, 11);
            this.lblNameHeading.Name = "lblNameHeading";
            this.lblNameHeading.Size = new System.Drawing.Size(34, 13);
            this.lblNameHeading.TabIndex = 0;
            this.lblNameHeading.Text = "Naziv";
            // 
            // lblPriceHeading
            // 
            this.lblPriceHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPriceHeading.AutoSize = true;
            this.lblPriceHeading.Location = new System.Drawing.Point(113, 11);
            this.lblPriceHeading.Name = "lblPriceHeading";
            this.lblPriceHeading.Size = new System.Drawing.Size(32, 13);
            this.lblPriceHeading.TabIndex = 1;
            this.lblPriceHeading.Text = "Cena";
            // 
            // lblDiscountHeading
            // 
            this.lblDiscountHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscountHeading.AutoSize = true;
            this.lblDiscountHeading.Location = new System.Drawing.Point(196, 11);
            this.lblDiscountHeading.Name = "lblDiscountHeading";
            this.lblDiscountHeading.Size = new System.Drawing.Size(40, 13);
            this.lblDiscountHeading.TabIndex = 2;
            this.lblDiscountHeading.Text = "Popust";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "{INCODE}";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(188, 47);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(56, 13);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "{INCODE}";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(101, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "{INCODE}";
            // 
            // AddProductToReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 239);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblQunatity);
            this.Controls.Add(this.btnAddToReceipt);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "AddProductToReceiptView";
            this.Text = "AddProductToBillView";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAddToReceipt;
        private System.Windows.Forms.Label lblQunatity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDiscountHeading;
        private System.Windows.Forms.Label lblPriceHeading;
        private System.Windows.Forms.Label lblNameHeading;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscount;
    }
}