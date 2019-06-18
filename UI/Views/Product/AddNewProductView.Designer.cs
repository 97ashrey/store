namespace UI.Views.Product
{
    partial class AddNewProductView
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panelBtnContainer = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbPrice = new UI.UserControls.NumberTextBox();
            this.tbDiscount = new UI.UserControls.NumberTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBtnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.88773F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.11227F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDiscount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbDiscount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 136);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Naziv";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 62);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Cena";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(3, 107);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(40, 13);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Popust";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbName.Location = new System.Drawing.Point(55, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 20);
            this.tbName.TabIndex = 1;
            // 
            // panelBtnContainer
            // 
            this.panelBtnContainer.Controls.Add(this.btnAddProduct);
            this.panelBtnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnContainer.Location = new System.Drawing.Point(10, 146);
            this.panelBtnContainer.Name = "panelBtnContainer";
            this.panelBtnContainer.Padding = new System.Windows.Forms.Padding(5);
            this.panelBtnContainer.Size = new System.Drawing.Size(250, 45);
            this.panelBtnContainer.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.Location = new System.Drawing.Point(5, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(240, 35);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Dodaj";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPrice.Decimals = true;
            this.tbPrice.Location = new System.Drawing.Point(55, 59);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Numbers = true;
            this.tbPrice.Size = new System.Drawing.Size(170, 20);
            this.tbPrice.TabIndex = 2;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbDiscount.Decimals = true;
            this.tbDiscount.Location = new System.Drawing.Point(55, 104);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Numbers = true;
            this.tbDiscount.Size = new System.Drawing.Size(170, 20);
            this.tbDiscount.TabIndex = 3;
            // 
            // AddNewProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 201);
            this.Controls.Add(this.panelBtnContainer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewProductView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "AddNewProductView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelBtnContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscount;
        private UserControls.NumberTextBox tbPrice;
        private UserControls.NumberTextBox tbDiscount;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panelBtnContainer;
        private System.Windows.Forms.ErrorProvider errorProvider;
        protected System.Windows.Forms.Button btnAddProduct;
    }
}