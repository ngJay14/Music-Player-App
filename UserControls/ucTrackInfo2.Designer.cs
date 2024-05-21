namespace musicPlayer.UserControls
{
    partial class ucTrackInfo2
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
            this.lbTrackName = new System.Windows.Forms.Label();
            this.lbSingerName = new System.Windows.Forms.Label();
            this.btnInfo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAddPlaylist = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pcTrackImage = new System.Windows.Forms.PictureBox();
            this.btnLike = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbDownloadTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcTrackImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTrackName
            // 
            this.lbTrackName.AutoSize = true;
            this.lbTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrackName.ForeColor = System.Drawing.Color.White;
            this.lbTrackName.Location = new System.Drawing.Point(88, 13);
            this.lbTrackName.Name = "lbTrackName";
            this.lbTrackName.Size = new System.Drawing.Size(120, 24);
            this.lbTrackName.TabIndex = 1;
            this.lbTrackName.Text = "Track name";
            // 
            // lbSingerName
            // 
            this.lbSingerName.AutoSize = true;
            this.lbSingerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSingerName.ForeColor = System.Drawing.Color.DarkGray;
            this.lbSingerName.Location = new System.Drawing.Point(92, 47);
            this.lbSingerName.Name = "lbSingerName";
            this.lbSingerName.Size = new System.Drawing.Size(83, 16);
            this.lbSingerName.TabIndex = 2;
            this.lbSingerName.Text = "Singer name";
            // 
            // btnInfo
            // 
            this.btnInfo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnInfo.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnInfo.Image = global::musicPlayer.Properties.Resources.menu_vertical_50px;
            this.btnInfo.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnInfo.ImageRotate = 0F;
            this.btnInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInfo.Location = new System.Drawing.Point(366, 25);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnInfo.Size = new System.Drawing.Size(30, 30);
            this.btnInfo.TabIndex = 11;
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddPlaylist.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddPlaylist.Image = global::musicPlayer.Properties.Resources.plus_no_circle_50px;
            this.btnAddPlaylist.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddPlaylist.ImageRotate = 0F;
            this.btnAddPlaylist.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddPlaylist.Location = new System.Drawing.Point(333, 25);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddPlaylist.Size = new System.Drawing.Size(30, 30);
            this.btnAddPlaylist.TabIndex = 10;
            // 
            // pcTrackImage
            // 
            this.pcTrackImage.Location = new System.Drawing.Point(5, 5);
            this.pcTrackImage.Name = "pcTrackImage";
            this.pcTrackImage.Size = new System.Drawing.Size(70, 70);
            this.pcTrackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTrackImage.TabIndex = 0;
            this.pcTrackImage.TabStop = false;
            // 
            // btnLike
            // 
            this.btnLike.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLike.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLike.Image = global::musicPlayer.Properties.Resources.heart_50px;
            this.btnLike.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLike.ImageRotate = 0F;
            this.btnLike.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLike.Location = new System.Drawing.Point(300, 25);
            this.btnLike.Name = "btnLike";
            this.btnLike.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLike.Size = new System.Drawing.Size(30, 30);
            this.btnLike.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Image = global::musicPlayer.Properties.Resources.remove_50px;
            this.btnDelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.ImageRotate = 0F;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(267, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Visible = false;
            // 
            // lbDownloadTime
            // 
            this.lbDownloadTime.AutoSize = true;
            this.lbDownloadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDownloadTime.ForeColor = System.Drawing.Color.DarkGray;
            this.lbDownloadTime.Location = new System.Drawing.Point(267, 59);
            this.lbDownloadTime.Name = "lbDownloadTime";
            this.lbDownloadTime.Size = new System.Drawing.Size(96, 16);
            this.lbDownloadTime.TabIndex = 14;
            this.lbDownloadTime.Text = "Download time";
            this.lbDownloadTime.Visible = false;
            // 
            // ucTrackInfo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbDownloadTime);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.lbSingerName);
            this.Controls.Add(this.lbTrackName);
            this.Controls.Add(this.pcTrackImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucTrackInfo2";
            this.Size = new System.Drawing.Size(400, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pcTrackImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcTrackImage;
        private System.Windows.Forms.Label lbTrackName;
        private System.Windows.Forms.Label lbSingerName;
        private Guna.UI2.WinForms.Guna2ImageButton btnInfo;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddPlaylist;
        private Guna.UI2.WinForms.Guna2ImageButton btnLike;
        private Guna.UI2.WinForms.Guna2ImageButton btnDelete;
        private System.Windows.Forms.Label lbDownloadTime;
    }
}
