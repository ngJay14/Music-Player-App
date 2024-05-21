namespace musicPlayer.UserControls
{
    partial class ucPlaylist
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
            this.btnDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pcPlaylistImage = new System.Windows.Forms.PictureBox();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcPlaylistImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Image = global::musicPlayer.Properties.Resources.remove_50px;
            this.btnDelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.ImageRotate = 0F;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(358, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 12;
            // 
            // pcPlaylistImage
            // 
            this.pcPlaylistImage.Image = global::musicPlayer.Properties.Resources.folder_50px;
            this.pcPlaylistImage.Location = new System.Drawing.Point(13, 5);
            this.pcPlaylistImage.Name = "pcPlaylistImage";
            this.pcPlaylistImage.Size = new System.Drawing.Size(70, 70);
            this.pcPlaylistImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPlaylistImage.TabIndex = 2;
            this.pcPlaylistImage.TabStop = false;
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.BackColor = System.Drawing.Color.Black;
            this.txtPlaylistName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaylistName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistName.ForeColor = System.Drawing.Color.White;
            this.txtPlaylistName.Location = new System.Drawing.Point(98, 27);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.ReadOnly = true;
            this.txtPlaylistName.Size = new System.Drawing.Size(132, 22);
            this.txtPlaylistName.TabIndex = 13;
            this.txtPlaylistName.Text = "Playlist name";
            this.txtPlaylistName.TextChanged += new System.EventHandler(this.txtPlaylistName_TextChanged);
            this.txtPlaylistName.DoubleClick += new System.EventHandler(this.txtPlaylistName_DoubleClick);
            this.txtPlaylistName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlaylistName_KeyDown);
            // 
            // ucPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pcPlaylistImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucPlaylist";
            this.Size = new System.Drawing.Size(400, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pcPlaylistImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcPlaylistImage;
        private Guna.UI2.WinForms.Guna2ImageButton btnDelete;
        private System.Windows.Forms.TextBox txtPlaylistName;
    }
}
