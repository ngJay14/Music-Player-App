namespace musicPlayer.UserControls
{
    partial class ucTrackInfo1
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
            this.pcTrackImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbTrackName = new System.Windows.Forms.Label();
            this.lbSingerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcTrackImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcTrackImage
            // 
            this.pcTrackImage.BorderRadius = 8;
            this.pcTrackImage.ImageRotate = 0F;
            this.pcTrackImage.Location = new System.Drawing.Point(0, 0);
            this.pcTrackImage.Name = "pcTrackImage";
            this.pcTrackImage.Size = new System.Drawing.Size(130, 130);
            this.pcTrackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTrackImage.TabIndex = 0;
            this.pcTrackImage.TabStop = false;
            // 
            // lbTrackName
            // 
            this.lbTrackName.AutoSize = true;
            this.lbTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrackName.ForeColor = System.Drawing.Color.White;
            this.lbTrackName.Location = new System.Drawing.Point(4, 137);
            this.lbTrackName.Name = "lbTrackName";
            this.lbTrackName.Size = new System.Drawing.Size(74, 13);
            this.lbTrackName.TabIndex = 1;
            this.lbTrackName.Text = "Track name";
            // 
            // lbSingerName
            // 
            this.lbSingerName.AutoSize = true;
            this.lbSingerName.ForeColor = System.Drawing.Color.DarkGray;
            this.lbSingerName.Location = new System.Drawing.Point(4, 154);
            this.lbSingerName.Name = "lbSingerName";
            this.lbSingerName.Size = new System.Drawing.Size(66, 13);
            this.lbSingerName.TabIndex = 2;
            this.lbSingerName.Text = "Singer name";
            // 
            // ucTrackInfo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbSingerName);
            this.Controls.Add(this.lbTrackName);
            this.Controls.Add(this.pcTrackImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucTrackInfo1";
            this.Size = new System.Drawing.Size(130, 170);
            ((System.ComponentModel.ISupportInitialize)(this.pcTrackImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pcTrackImage;
        private System.Windows.Forms.Label lbTrackName;
        private System.Windows.Forms.Label lbSingerName;
    }
}
