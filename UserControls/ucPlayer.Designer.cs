namespace musicPlayer.UserControls
{
    partial class ucPlayer
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
            this.lbSingerName = new System.Windows.Forms.Label();
            this.lbTrackName = new System.Windows.Forms.Label();
            this.btnInfo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLike = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pcTrackImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcTrackImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSingerName
            // 
            this.lbSingerName.AutoSize = true;
            this.lbSingerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSingerName.ForeColor = System.Drawing.Color.DarkGray;
            this.lbSingerName.Location = new System.Drawing.Point(79, 39);
            this.lbSingerName.Name = "lbSingerName";
            this.lbSingerName.Size = new System.Drawing.Size(66, 13);
            this.lbSingerName.TabIndex = 5;
            this.lbSingerName.Text = "Singer name";
            // 
            // lbTrackName
            // 
            this.lbTrackName.AutoSize = true;
            this.lbTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrackName.ForeColor = System.Drawing.Color.White;
            this.lbTrackName.Location = new System.Drawing.Point(77, 15);
            this.lbTrackName.Name = "lbTrackName";
            this.lbTrackName.Size = new System.Drawing.Size(97, 18);
            this.lbTrackName.TabIndex = 4;
            this.lbTrackName.Text = "Track name";
            // 
            // btnInfo
            // 
            this.btnInfo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnInfo.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnInfo.Image = global::musicPlayer.Properties.Resources.menu_vertical_50px;
            this.btnInfo.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnInfo.ImageRotate = 0F;
            this.btnInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInfo.Location = new System.Drawing.Point(347, 19);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 9;
            // 
            // btnLike
            // 
            this.btnLike.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLike.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLike.Image = global::musicPlayer.Properties.Resources.heart_50px;
            this.btnLike.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLike.ImageRotate = 0F;
            this.btnLike.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLike.Location = new System.Drawing.Point(308, 19);
            this.btnLike.Name = "btnLike";
            this.btnLike.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLike.Size = new System.Drawing.Size(40, 40);
            this.btnLike.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Image = global::musicPlayer.Properties.Resources.cancel_50px1;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(393, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 7;
            // 
            // btnPlay
            // 
            this.btnPlay.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlay.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPlay.Image = global::musicPlayer.Properties.Resources.stop_50px;
            this.btnPlay.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPlay.ImageRotate = 0F;
            this.btnPlay.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlay.Location = new System.Drawing.Point(262, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 6;
            // 
            // pcTrackImage
            // 
            this.pcTrackImage.Location = new System.Drawing.Point(15, 11);
            this.pcTrackImage.Name = "pcTrackImage";
            this.pcTrackImage.Size = new System.Drawing.Size(50, 50);
            this.pcTrackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTrackImage.TabIndex = 3;
            this.pcTrackImage.TabStop = false;
            // 
            // ucPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbSingerName);
            this.Controls.Add(this.lbTrackName);
            this.Controls.Add(this.pcTrackImage);
            this.Name = "ucPlayer";
            this.Size = new System.Drawing.Size(430, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pcTrackImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSingerName;
        private System.Windows.Forms.Label lbTrackName;
        private System.Windows.Forms.PictureBox pcTrackImage;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlay;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2ImageButton btnLike;
        private Guna.UI2.WinForms.Guna2ImageButton btnInfo;
    }
}
