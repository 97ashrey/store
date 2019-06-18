namespace UI.UserControls
{
    partial class UCHeading
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(362, 60);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Heading";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCHeading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHeading);
            this.MaximumSize = new System.Drawing.Size(0, 60);
            this.MinimumSize = new System.Drawing.Size(0, 60);
            this.Name = "UCHeading";
            this.Size = new System.Drawing.Size(362, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
    }
}
