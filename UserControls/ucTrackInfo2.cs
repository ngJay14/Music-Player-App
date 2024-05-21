using musicPlayer.Classes;
using musicPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicPlayer.UserControls
{
    public partial class ucTrackInfo2 : UserControl
    {
        public ucTrackInfo2()
        {
            InitializeComponent();
            WireAllControls(this);
        }

        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                if (ctl.Name == "btnLike" || ctl.Name == "btnInfo" || ctl.Name == "btnDelete" || ctl.Name == "btnAddPlaylist")
                    continue;
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void ctl_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

        private Image trackImage;
        private string trackName;
        private string singerName;
        private int trackId;
        private bool playlistBelong;
        private bool liked;
        private bool downloaded;

        public Image TrackImage
        {
            get { return trackImage; }
            set { trackImage = value; pcTrackImage.Image = value; }
        }

        public string TrackName
        {
            get { return trackName; }
            set { trackName = value; lbTrackName.Text = setText(value); }
        }

        public string SingerName
        {
            get { return singerName; }
            set { singerName = value; lbSingerName.Text = setText(value); }
        }

        public int TrackId
        { get { return trackId; } set { trackId = value; } }

        public bool PlaylistBelong
        {
            get { return playlistBelong; }
            set { playlistBelong = value; setDeleteBtn(value); }
        }

        public bool Liked
        {
            get { return liked; }
            set { liked = value; setLikeImage(value); }
        }

        public bool Download
        {
            get { return downloaded; }
            set { downloaded = value; setDownloadTime(value); }
        }

        private void setDownloadTime(bool visible)
        {
            if (visible)
            {
                SqlAdapter sqlAdapter = new SqlAdapter();

                DateTime downTime = sqlAdapter.getDownloadTimeByTrackId(trackId);

                lbDownloadTime.Text = downTime.ToString("HH:mm:ss dd/MM/yyyy");
                lbDownloadTime.Visible = true;
            }
        }

        private void setLikeImage(bool liked)
        {
            if (liked)
                btnLike.Image = Resources.fill_heart_50px;
            else
                btnLike.Image = Resources.heart_50px;
        }

        private void setDeleteBtn(bool visible)
        {
            if(visible) 
                btnDelete.Visible = true;
        }

        // Set text size if too long
        private string setText(string txt)
        {
            int txtLen = 15;
            if (txt.Length > txtLen)
            {
                txt = string.Concat(txt.Substring(0, txtLen), "...");
            }

            return txt;
        }

        public void disableBtnLike()
        {
            btnLike.Visible = false;
            btnDelete.Location = new Point(300, 25);
        }

        public event EventHandler AddBtnInfoClick
        {
            add { btnInfo.Click += value; }
            remove { btnInfo.Click -= value; }
        }

        public event EventHandler AddBtnDeleteClick
        {
            add { btnDelete.Click += value; }
            remove { btnDelete.Click -= value; }
        }

        public event EventHandler AddBtnLikeClick
        {
            add { btnLike.Click += value; }
            remove { btnLike.Click -= value; }
        }

        public event EventHandler AddBtnAddPlaylistClick
        {
            add { btnAddPlaylist.Click += value; }
            remove { btnAddPlaylist.Click -= value; }
        }
    }
}
