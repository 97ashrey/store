namespace UI.Views.Product
{
    partial class ProductsView
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
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.ucHeading1 = new UI.UserControls.UCHeading();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(179, 38);
            this.btnAddNewProduct.TabIndex = 0;
            this.btnAddNewProduct.Text = "Dodaj novi proizvod";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoScrollMargin = new System.Drawing.Size(100, 5);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 104);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(5);
            this.panelMain.Size = new System.Drawing.Size(370, 234);
            this.panelMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddNewProduct, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 44);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(188, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ucHeading1
            // 
            this.ucHeading1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucHeading1.HeadingText = "Proizvodi";
            this.ucHeading1.Location = new System.Drawing.Point(0, 0);
            this.ucHeading1.MaximumSize = new System.Drawing.Size(0, 60);
            this.ucHeading1.MinimumSize = new System.Drawing.Size(0, 60);
            this.ucHeading1.Name = "ucHeading1";
            this.ucHeading1.Size = new System.Drawing.Size(370, 60);
            this.ucHeading1.TabIndex = 0;
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ucHeading1);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(370, 338);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCHeading ucHeading1;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Panel panelMain;
        private UserControls.UCProduct ucProduct1;
        private UserControls.UCProduct ucProduct2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBack;
    }
}
