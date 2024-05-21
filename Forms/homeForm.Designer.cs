namespace musicPlayer
{
    partial class homeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.pnNavbar = new System.Windows.Forms.Panel();
            this.pnDownloadNav = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnLibraryNav = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnSearchNav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnHomeNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flPnHome = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBanner = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.flPnRecTracks = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.flPnCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.flPnTypeTracks = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnTypeTracks = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDownload = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLibrary = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tracksPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnNavbar.SuspendLayout();
            this.pnDownloadNav.SuspendLayout();
            this.pnLibraryNav.SuspendLayout();
            this.pnSearchNav.SuspendLayout();
            this.pnHomeNav.SuspendLayout();
            this.flPnHome.SuspendLayout();
            this.pnBanner.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.pnTypeTracks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracksPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
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
            this.pnLibraryNav.BackColor = System.Drawing.Color.Transparent;
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
            this.pnHomeNav.BackColor = System.Drawing.Color.DarkGray;
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
            // flPnHome
            // 
            this.flPnHome.BackColor = System.Drawing.Color.Black;
            this.flPnHome.Controls.Add(this.pnBanner);
            this.flPnHome.Controls.Add(this.label5);
            this.flPnHome.Controls.Add(this.flPnRecTracks);
            this.flPnHome.Controls.Add(this.label6);
            this.flPnHome.Controls.Add(this.flPnCategories);
            this.flPnHome.Location = new System.Drawing.Point(0, 30);
            this.flPnHome.Name = "flPnHome";
            this.flPnHome.Size = new System.Drawing.Size(430, 747);
            this.flPnHome.TabIndex = 3;
            // 
            // pnBanner
            // 
            this.pnBanner.Controls.Add(this.tracksPlayer);
            this.pnBanner.Controls.Add(this.guna2PictureBox1);
            this.pnBanner.Controls.Add(this.guna2PictureBox2);
            this.pnBanner.Location = new System.Drawing.Point(3, 3);
            this.pnBanner.Name = "pnBanner";
            this.pnBanner.Size = new System.Drawing.Size(427, 351);
            this.pnBanner.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Recent tracks";
            // 
            // flPnRecTracks
            // 
            this.flPnRecTracks.AutoScroll = true;
            this.flPnRecTracks.Location = new System.Drawing.Point(3, 382);
            this.flPnRecTracks.Name = "flPnRecTracks";
            this.flPnRecTracks.Size = new System.Drawing.Size(430, 175);
            this.flPnRecTracks.TabIndex = 9;
            this.flPnRecTracks.WrapContents = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categories";
            // 
            // flPnCategories
            // 
            this.flPnCategories.AutoScroll = true;
            this.flPnCategories.Location = new System.Drawing.Point(3, 585);
            this.flPnCategories.Name = "flPnCategories";
            this.flPnCategories.Size = new System.Drawing.Size(430, 157);
            this.flPnCategories.TabIndex = 11;
            this.flPnCategories.WrapContents = false;
            // 
            // flPnTypeTracks
            // 
            this.flPnTypeTracks.AutoScroll = true;
            this.flPnTypeTracks.BackColor = System.Drawing.Color.Black;
            this.flPnTypeTracks.Location = new System.Drawing.Point(0, 71);
            this.flPnTypeTracks.Name = "flPnTypeTracks";
            this.flPnTypeTracks.Padding = new System.Windows.Forms.Padding(15, 0, 0, 100);
            this.flPnTypeTracks.Size = new System.Drawing.Size(430, 671);
            this.flPnTypeTracks.TabIndex = 6;
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Controls.Add(this.btnBack);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(430, 68);
            this.pnTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(75, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(50, 24);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title";
            // 
            // pnTypeTracks
            // 
            this.pnTypeTracks.BackColor = System.Drawing.Color.Black;
            this.pnTypeTracks.Controls.Add(this.flPnTypeTracks);
            this.pnTypeTracks.Controls.Add(this.pnTitle);
            this.pnTypeTracks.Location = new System.Drawing.Point(0, 30);
            this.pnTypeTracks.Name = "pnTypeTracks";
            this.pnTypeTracks.Size = new System.Drawing.Size(430, 738);
            this.pnTypeTracks.TabIndex = 1;
            this.pnTypeTracks.Visible = false;
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
            // tracksPlayer
            // 
            this.tracksPlayer.Enabled = true;
            this.tracksPlayer.Location = new System.Drawing.Point(48, 228);
            this.tracksPlayer.Name = "tracksPlayer";
            this.tracksPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tracksPlayer.OcxState")));
            this.tracksPlayer.Size = new System.Drawing.Size(178, 72);
            this.tracksPlayer.TabIndex = 5;
            this.tracksPlayer.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 8;
            this.guna2PictureBox1.Image = global::musicPlayer.Properties.Resources._113c6d5e69011f4fb516222424aa89ff1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(9, 11);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(405, 195);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderRadius = 8;
            this.guna2PictureBox2.Image = global::musicPlayer.Properties.Resources._2726fad6f25a42a00578c9018b7648f5;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(9, 212);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(405, 130);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 4;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBack.Image = global::musicPlayer.Properties.Resources.left_50px;
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.Location = new System.Drawing.Point(11, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(430, 852);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnNavbar);
            this.Controls.Add(this.flPnHome);
            this.Controls.Add(this.pnTypeTracks);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.homeForm_Load);
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
            this.flPnHome.ResumeLayout(false);
            this.flPnHome.PerformLayout();
            this.pnBanner.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnTypeTracks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tracksPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flPnHome;
        private System.Windows.Forms.Panel pnBanner;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flPnRecTracks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flPnCategories;
        private AxWMPLib.AxWindowsMediaPlayer tracksPlayer;
        private System.Windows.Forms.FlowLayoutPanel flPnTypeTracks;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private System.Windows.Forms.Panel pnTypeTracks;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

