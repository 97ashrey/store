namespace UI.UserControls
{
    partial class UCProduct
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpProduct = new System.Windows.Forms.TableLayoutPanel();
            this.lblDiscountHeading = new System.Windows.Forms.Label();
            this.lblPriceHeading = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.SystemColors.Control;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.80795F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.19205F));
            this.tlpMain.Controls.Add(this.tlpProduct, 0, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(2, 2);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(442, 89);
            this.tlpMain.TabIndex = 6;
            // 
            // tlpProduct
            // 
            this.tlpProduct.ColumnCount = 3;
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpProduct.Controls.Add(this.lblDiscountHeading, 2, 0);
            this.tlpProduct.Controls.Add(this.lblPriceHeading, 1, 0);
            this.tlpProduct.Controls.Add(this.lblPrice, 1, 1);
            this.tlpProduct.Controls.Add(this.lblDiscount, 2, 1);
            this.tlpProduct.Controls.Add(this.lblName, 0, 1);
            this.tlpProduct.Controls.Add(this.lblNameHeading, 0, 0);
            this.tlpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProduct.Location = new System.Drawing.Point(3, 3);
            this.tlpProduct.Name = "tlpProduct";
            this.tlpProduct.RowCount = 2;
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProduct.Size = new System.Drawing.Size(342, 83);
            this.tlpProduct.TabIndex = 0;
            // 
            // lblDiscountHeading
            // 
            this.lblDiscountHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscountHeading.AutoSize = true;
            this.lblDiscountHeading.Location = new System.Drawing.Point(265, 4);
            this.lblDiscountHeading.Name = "lblDiscountHeading";
            this.lblDiscountHeading.Size = new System.Drawing.Size(40, 13);
            this.lblDiscountHeading.TabIndex = 5;
            this.lblDiscountHeading.Text = "Popust";
            // 
            // lblPriceHeading
            // 
            this.lblPriceHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPriceHeading.AutoSize = true;
            this.lblPriceHeading.Location = new System.Drawing.Point(155, 4);
            this.lblPriceHeading.Name = "lblPriceHeading";
            this.lblPriceHeading.Size = new System.Drawing.Size(32, 13);
            this.lblPriceHeading.TabIndex = 4;
            this.lblPriceHeading.Text = "Cena";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(143, 46);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "{INCODE}";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(257, 46);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(56, 13);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "{INCODE}";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "{INCODE}";
            // 
            // lblNameHeading
            // 
            this.lblNameHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameHeading.AutoSize = true;
            this.lblNameHeading.Location = new System.Drawing.Point(40, 4);
            this.lblNameHeading.Name = "lblNameHeading";
            this.lblNameHeading.Size = new System.Drawing.Size(34, 13);
            this.lblNameHeading.TabIndex = 3;
            this.lblNameHeading.Text = "Naziv";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tlpMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(446, 93);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(351, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(88, 83);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 21);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(3, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 21);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(3, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(0, 95);
            this.Name = "UCProduct";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Size = new System.Drawing.Size(446, 98);
            this.tlpMain.ResumeLayout(false);
            this.tlpProduct.ResumeLayout(false);
            this.tlpProduct.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpProduct;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDiscountHeading;
        private System.Windows.Forms.Label lblPriceHeading;
        private System.Windows.Forms.Label lblNameHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}
