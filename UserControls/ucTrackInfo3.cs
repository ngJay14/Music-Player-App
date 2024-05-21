using musicPlayer.Classes;
using musicPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace musicPlayer.UserControls
{
    public partial class ucTrackInfo3 : UserControl
    {
        public ucTrackInfo3()
        {
            InitializeComponent();
        }

        private Image trackImage;
        private string trackName;
        private string singerName;
        private int playlistId;
        private bool played;
        private bool liked;
        private int trackId;
        private bool rating;

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

        public bool Played
        {
            get { return played; }
            set { played = value; setPlayStatus(value); }
        }

        public int PlaylistId
        { get { return playlistId; } set { playlistId = value; } }

        public bool Liked
        {
            get { return liked; }
            set { liked = value; setLikeImage(value); }
        }
        public int TrackId
        { get { return trackId; } set { trackId = value; } }

        public bool Rating
        {
            get { return rating; }
            set { rating = value; setRating(value); }
        }

        private void setRating(bool visible)
        {
            if (visible)
            {
                SqlAdapter sqlAdapter = new SqlAdapter();

                lbRatingValue.Text = sqlAdapter.getRatingCountByTrackId(trackId).ToString() + "/10";
            }
        }

        private void setLikeImage(bool liked)
        {
            if (liked)
                btnLike.Image = Resources.fill_heart_50px;
            else
                btnLike.Image = Resources.heart_50px;
        }


        public event EventHandler AddBtnPlayClick
        {
            add { btnPlay.Click += value; }
            remove { btnPlay.Click -= value; }
        }

        public event EventHandler AddBtnLikeClick
        {
            add { btnLike.Click += value; }
            remove { btnLike.Click -= value; }
        }

        public event EventHandler AddBtnBackClick
        {
            add { btnBack.Click += value; }
            remove { btnBack.Click -= value; }
        }

        public event EventHandler AddBtnAddIntoPlaylistClick
        {
            add { btnAddIntoPlaylist.Click += value; }
            remove { btnAddIntoPlaylist.Click -= value; }
        }

        public event EventHandler AddBtnDownloadClick
        {
            add { btnDownload.Click += value; }
            remove { btnDownload.Click -= value; }
        }

        // Set text size if too long
        private string setText(string txt)
        {
            int txt_length = 25;

            if (txt.Length > txt_length)
            {
                txt = string.Concat(txt.Substring(0, txt_length), "...");
            }

            return txt;
        }

        private void setPlayStatus(bool status)
        {
            if (status) { btnPlay.Image = Resources.stop_50px; }
            else { btnPlay.Image = Resources.play_50px; }
        }
    }
}
