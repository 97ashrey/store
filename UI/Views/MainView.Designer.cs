namespace UI.Views
{
    partial class MainView
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelPageContainer = new System.Windows.Forms.Panel();
            this.panelButtonContainer = new System.Windows.Forms.Panel();
            this.btnCheckReceipts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelPageContainer);
            this.splitContainer.Panel2.Controls.Add(this.panelButtonContainer);
            this.splitContainer.Size = new System.Drawing.Size(774, 457);
            this.splitContainer.SplitterDistance = 251;
            this.splitContainer.TabIndex = 0;
            // 
            // panelPageContainer
            // 
            this.panelPageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPageContainer.Location = new System.Drawing.Point(0, 42);
            this.panelPageContainer.Name = "panelPageContainer";
            this.panelPageContainer.Size = new System.Drawing.Size(519, 415);
            this.panelPageContainer.TabIndex = 1;
            // 
            // panelButtonContainer
            // 
            this.panelButtonContainer.Controls.Add(this.btnCheckReceipts);
            this.panelButtonContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonContainer.Location = new System.Drawing.Point(0, 0);
            this.panelButtonContainer.Name = "panelButtonContainer";
            this.panelButtonContainer.Padding = new System.Windows.Forms.Padding(5);
            this.panelButtonContainer.Size = new System.Drawing.Size(519, 42);
            this.panelButtonContainer.TabIndex = 0;
            // 
            // btnCheckReceipts
            // 
            this.btnCheckReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckReceipts.Location = new System.Drawing.Point(5, 5);
            this.btnCheckReceipts.Name = "btnCheckReceipts";
            this.btnCheckReceipts.Size = new System.Drawing.Size(509, 32);
            this.btnCheckReceipts.TabIndex = 0;
            this.btnCheckReceipts.Text = "Pogledajte račune";
            this.btnCheckReceipts.UseVisualStyleBackColor = true;
            this.btnCheckReceipts.Click += new System.EventHandler(this.btnCheckReceipts_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 457);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainView";
            this.Text = "MainView";
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelButtonContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelPageContainer;
        private System.Windows.Forms.Panel panelButtonContainer;
        private System.Windows.Forms.Button btnCheckReceipts;
    }
}