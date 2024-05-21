using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicPlayer.UserControls
{
    public partial class ucTrackInfo1 : UserControl
    {
        public ucTrackInfo1()
        {
            InitializeComponent();
            WireAllControls(this);
        }

        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
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

        private int trackId;
        private Image trackImage;
        private string trackName;
        private string singerName;
        private int playlistId;

        public int TrackId
        {
            get { return trackId; }
            set { trackId = value; }
        }

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

        public int PlaylistId
        { get { return playlistId; } set { playlistId = value; } }

        // Set text size if too long
        private string setText(string txt)
        {
            if (txt.Length > 19)
            {
               txt = string.Concat(txt.Substring(0, 19), "...");
            }

            return txt;
        }

    }
}
