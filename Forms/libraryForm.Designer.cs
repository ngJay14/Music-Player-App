namespace musicPlayer
{
    partial class libraryForm
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
            this.pnNavbar = new System.Windows.Forms.Panel();
            this.pnDownloadNav = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnLibraryNav = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnSearchNav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnHomeNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.flPnPlaylists = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnPlaylistDetail = new System.Windows.Forms.Panel();
            this.flPnPlaylistDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPlaylistName = new System.Windows.Forms.Label();
            this.btnDeleteAllTracks = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDeletePlaylist = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDownload = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLibrary = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAddPlaylist = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnNavbar.SuspendLayout();
            this.pnDownloadNav.SuspendLayout();
            this.pnLibraryNav.SuspendLayout();
            this.pnSearchNav.SuspendLayout();
            this.pnHomeNav.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnPlaylistDetail.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNavbar
            // 
            this.pnNavbar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnNavbar.Controls.Add(this.pnDownloadNav);
            this.pnNavbar.Controls.Add(this.pnLibraryNav);
            this.pnNavbar.Controls.Add(this.pnSearchNav);
            this.pnNavbar.Controls.Add(this.pnHomeNav);
            this.pnNavbar.Location = new System.Drawing.Point(0, 774);
            this.pnNavbar.Name = "pnNavbar";
            this.pnNavbar.Size = new System.Drawing.Size(430, 80);
            this.pnNavbar.TabIndex = 0;
            // 
            // pnDownloadNav
            // 
            this.pnDownloadNav.BackColor = System.Drawing.Color.Transparent;
            this.pnDownloadNav.Controls.Add(this.label4);
            this.pnDownloadNav.Controls.Add(this.btnDownload);
            this.pnDownloadNav.Location = new System.Drawing.Point(331, 0);
            this.pnDownloadNav.Name = "pnDownloadNav";
            this.pnDownloadNav.Size = new System.Drawing.Size(87, 80);
            this.pnDownloadNav.TabIndex = 10;
            this.pnDownloadNav.Tag = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Download";
            // 
            // pnLibraryNav
            // 
            this.pnLibraryNav.BackColor = System.Drawing.Color.DarkGray;
            this.pnLibraryNav.Controls.Add(this.label3);
            this.pnLibraryNav.Controls.Add(this.btnLibrary);
            this.pnLibraryNav.Location = new System.Drawing.Point(225, 0);
            this.pnLibraryNav.Name = "pnLibraryNav";
            this.pnLibraryNav.Size = new System.Drawing.Size(87, 80);
            this.pnLibraryNav.TabIndex = 3;
            this.pnLibraryNav.Tag = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Library";
            // 
            // pnSearchNav
            // 
            this.pnSearchNav.BackColor = System.Drawing.Color.Transparent;
            this.pnSearchNav.Controls.Add(this.label2);
            this.pnSearchNav.Controls.Add(this.btnSearch);
            this.pnSearchNav.Location = new System.Drawing.Point(119, 0);
            this.pnSearchNav.Name = "pnSearchNav";
            this.pnSearchNav.Size = new System.Drawing.Size(87, 80);
            this.pnSearchNav.TabIndex = 2;
            this.pnSearchNav.Tag = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search";
            // 
            // pnHomeNav
            // 
            this.pnHomeNav.BackColor = System.Drawing.Color.Transparent;
            this.pnHomeNav.Controls.Add(this.label1);
            this.pnHomeNav.Controls.Add(this.btnHome);
            this.pnHomeNav.Location = new System.Drawing.Point(14, 0);
            this.pnHomeNav.Name = "pnHomeNav";
            this.pnHomeNav.Size = new System.Drawing.Size(87, 80);
            this.pnHomeNav.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Tag = "1";
            this.label1.Text = "Home";
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Black;
            this.pnMain.Controls.Add(this.flPnPlaylists);
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Location = new System.Drawing.Point(0, 30);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(430, 747);
            this.pnMain.TabIndex = 6;
            // 
            // flPnPlaylists
            // 
            this.flPnPlaylists.Location = new System.Drawing.Point(0, 63);
            this.flPnPlaylists.Name = "flPnPlaylists";
            this.flPnPlaylists.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flPnPlaylists.Size = new System.Drawing.Size(430, 681);
            this.flPnPlaylists.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddPlaylist);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 62);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Playlists";
            // 
            // pnPlaylistDetail
            // 
            this.pnPlaylistDetail.BackColor = System.Drawing.Color.Black;
            this.pnPlaylistDetail.Controls.Add(this.flPnPlaylistDetail);
            this.pnPlaylistDetail.Controls.Add(this.panel3);
            this.pnPlaylistDetail.Location = new System.Drawing.Point(0, 30);
            this.pnPlaylistDetail.Name = "pnPlaylistDetail";
            this.pnPlaylistDetail.Size = new System.Drawing.Size(430, 747);
            this.pnPlaylistDetail.TabIndex = 7;
            // 
            // flPnPlaylistDetail
            // 
            this.flPnPlaylistDetail.Location = new System.Drawing.Point(0, 63);
            this.flPnPlaylistDetail.Name = "flPnPlaylistDetail";
            this.flPnPlaylistDetail.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flPnPlaylistDetail.Size = new System.Drawing.Size(430, 681);
            this.flPnPlaylistDetail.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteAllTracks);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnDeletePlaylist);
            this.panel3.Controls.Add(this.lbPlaylistName);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 62);
            this.panel3.TabIndex = 2;
            // 
            // lbPlaylistName
            // 
            this.lbPlaylistName.AutoSize = true;
            this.lbPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaylistName.ForeColor = System.Drawing.Color.White;
            this.lbPlaylistName.Location = new System.Drawing.Point(49, 14);
            this.lbPlaylistName.Name = "lbPlaylistName";
            this.lbPlaylistName.Size = new System.Drawing.Size(188, 31);
            this.lbPlaylistName.TabIndex = 2;
            this.lbPlaylistName.Text = "Playlist name";
            // 
            // btnDeleteAllTracks
            // 
            this.btnDeleteAllTracks.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDeleteAllTracks.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeleteAllTracks.Image = global::musicPlayer.Properties.Resources.delete_view_50px;
            this.btnDeleteAllTracks.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteAllTracks.ImageRotate = 0F;
            this.btnDeleteAllTracks.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllTracks.Location = new System.Drawing.Point(324, 10);
            this.btnDeleteAllTracks.Name = "btnDeleteAllTracks";
            this.btnDeleteAllTracks.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeleteAllTracks.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteAllTracks.TabIndex = 6;
            this.btnDeleteAllTracks.Click += new System.EventHandler(this.btnDeleteAllTracks_Click);
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.Image = global::musicPlayer.Properties.Resources.left_50px;
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(3, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDeletePlaylist.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeletePlaylist.Image = global::musicPlayer.Properties.Resources.remove_50px;
            this.btnDeletePlaylist.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDeletePlaylist.ImageRotate = 0F;
            this.btnDeletePlaylist.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeletePlaylist.Location = new System.Drawing.Point(370, 10);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDeletePlaylist.Size = new System.Drawing.Size(40, 40);
            this.btnDeletePlaylist.TabIndex = 3;
            this.btnDeletePlaylist.Click += new System.EventHandler(this.btnDeletePlaylistDetails_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimize.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMinimize.Image = global::musicPlayer.Properties.Resources.minimize_window_50px;
            this.btnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.ImageRotate = 0F;
            this.btnMinimize.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMinimize.Location = new System.Drawing.Point(367, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Image = global::musicPlayer.Properties.Resources.icons8_delete_50px_1;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(400, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDownload.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDownload.Image = global::musicPlayer.Properties.Resources.download_60px;
            this.btnDownload.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDownload.ImageRotate = 0F;
            this.btnDownload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDownload.Location = new System.Drawing.Point(14, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDownload.Size = new System.Drawing.Size(60, 60);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Tag = "4";
            this.btnDownload.Click += new System.EventHandler(this.btnNavbar_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLibrary.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLibrary.Image = global::musicPlayer.Properties.Resources.music_library_60px;
            this.btnLibrary.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLibrary.ImageRotate = 0F;
            this.btnLibrary.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLibrary.Location = new System.Drawing.Point(12, 2);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLibrary.Size = new System.Drawing.Size(60, 60);
            this.btnLibrary.TabIndex = 7;
            this.btnLibrary.Tag = "3";
            this.btnLibrary.Click += new System.EventHandler(this.btnNavbar_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearch.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Image = global::musicPlayer.Properties.Resources.search_60px;
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageRotate = 0F;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(13, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Size = new System.Drawing.Size(60, 60);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Tag = "2";
            this.btnSearch.Click += new System.EventHandler(this.btnNavbar_Click);
            // 
            // btnHome
            // 
            this.btnHome.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHome.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnHome.Image = global::musicPlayer.Properties.Resources.home_60px;
            this.btnHome.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHome.ImageRotate = 0F;
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(14, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnHome.Size = new System.Drawing.Size(60, 60);
            this.btnHome.TabIndex = 5;
            this.btnHome.Tag = "1";
            this.btnHome.Click += new System.EventHandler(this.btnNavbar_Click);
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddPlaylist.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddPlaylist.Image = global::musicPlayer.Properties.Resources.plus_no_circle_50px;
            this.btnAddPlaylist.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddPlaylist.ImageRotate = 0F;
            this.btnAddPlaylist.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddPlaylist.Location = new System.Drawing.Point(370, 10);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddPlaylist.Size = new System.Drawing.Size(40, 40);
            this.btnAddPlaylist.TabIndex = 3;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // libraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(430, 852);
            this.Controls.Add(this.pnPlaylistDetail);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnNavbar);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "libraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.libraryForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.homeForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.homeForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.homeForm_MouseUp);
            this.pnNavbar.ResumeLayout(false);
            this.pnDownloadNav.ResumeLayout(false);
            this.pnDownloadNav.PerformLayout();
            this.pnLibraryNav.ResumeLayout(false);
            this.pnLibraryNav.PerformLayout();
            this.pnSearchNav.ResumeLayout(false);
            this.pnSearchNav.PerformLayout();
            this.pnHomeNav.ResumeLayout(false);
            this.pnHomeNav.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnPlaylistDetail.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnNavbar;
        private System.Windows.Forms.Panel pnHomeNav;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnHome;
        private System.Windows.Forms.Panel pnSearchNav;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private System.Windows.Forms.Panel pnDownloadNav;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ImageButton btnDownload;
        private System.Windows.Forms.Panel pnLibraryNav;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton btnLibrary;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinimize;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddPlaylist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flPnPlaylists;
        private System.Windows.Forms.Panel pnPlaylistDetail;
        private System.Windows.Forms.FlowLayoutPanel flPnPlaylistDetail;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ImageButton btnDeletePlaylist;
        private System.Windows.Forms.Label lbPlaylistName;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnDeleteAllTracks;
    }
}

