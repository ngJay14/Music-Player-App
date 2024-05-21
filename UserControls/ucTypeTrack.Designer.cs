namespace musicPlayer
{
    partial class ucTypeTrack
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
            this.lbText = new System.Windows.Forms.Label();
            this.pcTypeImage = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(9, 94);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(59, 20);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "label1";
            // 
            // pcTypeImage
            // 
            this.pcTypeImage.BorderRadius = 8;
            this.pcTypeImage.ImageRotate = 0F;
            this.pcTypeImage.Location = new System.Drawing.Point(0, 0);
            this.pcTypeImage.Name = "pcTypeImage";
            this.pcTypeImage.Size = new System.Drawing.Size(130, 130);
            this.pcTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTypeImage.TabIndex = 2;
            this.pcTypeImage.TabStop = false;
            // 
            // ucTypeTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.pcTypeImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucTypeTrack";
            this.Size = new System.Drawing.Size(130, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pcTypeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbText;
        private Guna.UI2.WinForms.Guna2PictureBox pcTypeImage;
    }
}
