namespace musicPlayer
{
    partial class searchForm
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
            this.btnDownload = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnLibraryNav = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLibrary = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnSearchNav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnHomeNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchTracks = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.flPnFindedTracks = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnNavbar.SuspendLayout();
            this.pnDownloadNav.SuspendLayout();
            this.pnLibraryNav.SuspendLayout();
            this.pnSearchNav.SuspendLayout();
            this.pnHomeNav.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pnSearchNav
            // 
            this.pnSearchNav.BackColor = System.Drawing.Color.DarkGray;
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
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Black;
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Controls.Add(this.flPnFindedTracks);
            this.pnMain.Location = new System.Drawing.Point(0, 30);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(430, 747);
            this.pnMain.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchTracks);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 120);
            this.panel1.TabIndex = 1;
            // 
            // btnSearchTracks
            // 
            this.btnSearchTracks.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearchTracks.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearchTracks.Image = global::musicPlayer.Properties.Resources.search_60px;
            this.btnSearchTracks.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearchTracks.ImageRotate = 0F;
            this.btnSearchTracks.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearchTracks.Location = new System.Drawing.Point(18, 62);
            this.btnSearchTracks.Name = "btnSearchTracks";
            this.btnSearchTracks.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearchTracks.Size = new System.Drawing.Size(35, 35);
            this.btnSearchTracks.TabIndex = 1;
            this.btnSearchTracks.Click += new System.EventHandler(this.btnSearchTracks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::musicPlayer.Properties.Resources.music_50px;
            this.pictureBox1.Location = new System.Drawing.Point(370, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(59, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "What do you wanna listen ?";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(351, 35);
            this.txtSearch.TabIndex = 0;
            // 
            // flPnFindedTracks
            // 
            this.flPnFindedTracks.Location = new System.Drawing.Point(0, 126);
            this.flPnFindedTracks.Name = "flPnFindedTracks";
            this.flPnFindedTracks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flPnFindedTracks.Size = new System.Drawing.Size(430, 620);
            this.flPnFindedTracks.TabIndex = 0;
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
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(430, 852);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnNavbar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flPnFindedTracks;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearchTracks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

