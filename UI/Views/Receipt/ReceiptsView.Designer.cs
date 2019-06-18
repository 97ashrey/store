namespace UI.Views.Receipt
{
    partial class ReceiptsView
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelControlsContainer = new System.Windows.Forms.Panel();
            this.panelTableContaner = new System.Windows.Forms.Panel();
            this.panelControlsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(19, 45);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(176, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Location = new System.Drawing.Point(256, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(176, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(79, 26);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(56, 13);
            this.lblDateFrom.TabIndex = 2;
            this.lblDateFrom.Text = "Datum od:";
            // 
            // lblDateTo
            // 
            this.lblDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(315, 26);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(53, 13);
            this.lblDateTo.TabIndex = 3;
            this.lblDateTo.Text = "Datum do";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(19, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(413, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelControlsContainer
            // 
            this.panelControlsContainer.Controls.Add(this.lblDateFrom);
            this.panelControlsContainer.Controls.Add(this.btnSearch);
            this.panelControlsContainer.Controls.Add(this.dtpFrom);
            this.panelControlsContainer.Controls.Add(this.lblDateTo);
            this.panelControlsContainer.Controls.Add(this.dtpTo);
            this.panelControlsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlsContainer.Location = new System.Drawing.Point(0, 0);
            this.panelControlsContainer.Name = "panelControlsContainer";
            this.panelControlsContainer.Size = new System.Drawing.Size(451, 133);
            this.panelControlsContainer.TabIndex = 5;
            // 
            // panelTableContaner
            // 
            this.panelTableContaner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTableContaner.Location = new System.Drawing.Point(0, 133);
            this.panelTableContaner.Name = "panelTableContaner";
            this.panelTableContaner.Size = new System.Drawing.Size(451, 288);
            this.panelTableContaner.TabIndex = 6;
            // 
            // ReceiptsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 421);
            this.Controls.Add(this.panelTableContaner);
            this.Controls.Add(this.panelControlsContainer);
            this.Name = "ReceiptsView";
            this.Text = "ReceiptsView";
            this.panelControlsContainer.ResumeLayout(false);
            this.panelControlsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelControlsContainer;
        private System.Windows.Forms.Panel panelTableContaner;
    }
}