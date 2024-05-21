namespace musicPlayer.UserControls
{
    partial class ucTrackInfo3
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
            this.btnAddIntoPlaylist = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLike = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pcTrackImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbRating = new System.Windows.Forms.Label();
            this.lbRatingValue = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDownload = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcTrackImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSingerName
            // 
            this.lbSingerName.AutoSize = true;
            this.lbSingerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSingerName.ForeColor = System.Drawing.Color.DarkGray;
            this.lbSingerName.Location = new System.Drawing.Point(33, 450);
            this.lbSingerName.Name = "lbSingerName";
            this.lbSingerName.Size = new System.Drawing.Size(99, 20);
            this.lbSingerName.TabIndex = 4;
            this.lbSingerName.Text = "Singer name";
            // 
            // lbTrackName
            // 
            this.lbTrackName.AutoSize = true;
            this.lbTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrackName.ForeColor = System.Drawing.Color.White;
            this.lbTrackName.Location = new System.Drawing.Point(32, 409);
            this.lbTrackName.Name = "lbTrackName";
            this.lbTrackName.Size = new System.Drawing.Size(150, 29);
            this.lbTrackName.TabIndex = 3;
            this.lbTrackName.Text = "Track name";
            // 
            // btnAddIntoPlaylist
            // 
            this.btnAddIntoPlaylist.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddIntoPlaylist.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddIntoPlaylist.Image = global::musicPlayer.Properties.Resources.plus_50px;
            this.btnAddIntoPlaylist.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddIntoPlaylist.ImageRotate = 0F;
            this.btnAddIntoPlaylist.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddIntoPlaylist.Location = new System.Drawing.Point(340, 514);
            this.btnAddIntoPlaylist.Name = "btnAddIntoPlaylist";
            this.btnAddIntoPlaylist.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddIntoPlaylist.Size = new System.Drawing.Size(50, 50);
            this.btnAddIntoPlaylist.TabIndex = 9;
            // 
            // btnLike
            // 
            this.btnLike.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLike.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnLike.Image = global::musicPlayer.Properties.Resources.heart_50px;
            this.btnLike.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLike.ImageRotate = 0F;
            this.btnLike.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLike.Location = new System.Drawing.Point(41, 514);
            this.btnLike.Name = "btnLike";
            this.btnLike.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnLike.Size = new System.Drawing.Size(50, 50);
            this.btnLike.TabIndex = 8;
            // 
            // btnPlay
            // 
            this.btnPlay.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlay.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnPlay.Image = global::musicPlayer.Properties.Resources.stop_50px;
            this.btnPlay.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPlay.ImageRotate = 0F;
            this.btnPlay.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPlay.Location = new System.Drawing.Point(132, 514);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 7;
            // 
            // pcTrackImage
            // 
            this.pcTrackImage.BorderRadius = 8;
            this.pcTrackImage.ImageRotate = 0F;
            this.pcTrackImage.Location = new System.Drawing.Point(36, 36);
            this.pcTrackImage.Name = "pcTrackImage";
            this.pcTrackImage.Size = new System.Drawing.Size(350, 350);
            this.pcTrackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTrackImage.TabIndex = 1;
            this.pcTrackImage.TabStop = false;
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRating.ForeColor = System.Drawing.Color.DarkGray;
            this.lbRating.Location = new System.Drawing.Point(33, 485);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(49, 16);
            this.lbRating.TabIndex = 10;
            this.lbRating.Text = "Rating:";
            // 
            // lbRatingValue
            // 
            this.lbRatingValue.AutoSize = true;
            this.lbRatingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRatingValue.ForeColor = System.Drawing.Color.DarkGray;
            this.lbRatingValue.Location = new System.Drawing.Point(82, 485);
            this.lbRatingValue.Name = "lbRatingValue";
            this.lbRatingValue.Size = new System.Drawing.Size(76, 16);
            this.lbRatingValue.TabIndex = 11;
            this.lbRatingValue.Text = "rating value";
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBack.Image = global::musicPlayer.Properties.Resources.left_50px;
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.Location = new System.Drawing.Point(5, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 12;
            // 
            // btnDownload
            // 
            this.btnDownload.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDownload.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDownload.Image = global::musicPlayer.Properties.Resources.download_60px;
            this.btnDownload.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDownload.ImageRotate = 0F;
            this.btnDownload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDownload.Location = new System.Drawing.Point(232, 514);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDownload.Size = new System.Drawing.Size(50, 50);
            this.btnDownload.TabIndex = 13;
            // 
            // ucTrackInfo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbRatingValue);
            this.Controls.Add(this.lbRating);
            this.Controls.Add(this.btnAddIntoPlaylist);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbSingerName);
            this.Controls.Add(this.lbTrackName);
            this.Controls.Add(this.pcTrackImage);
            this.Name = "ucTrackInfo3";
            this.Size = new System.Drawing.Size(430, 747);
            ((System.ComponentModel.ISupportInitialize)(this.pcTrackImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pcTrackImage;
        private System.Windows.Forms.Label lbSingerName;
        private System.Windows.Forms.Label lbTrackName;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlay;
        private Guna.UI2.WinForms.Guna2ImageButton btnLike;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddIntoPlaylist;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.Label lbRatingValue;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnDownload;
    }
}
