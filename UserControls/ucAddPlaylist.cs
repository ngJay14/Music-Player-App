using musicPlayer.Classes;
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
    public partial class ucAddPlaylist : UserControl
    {
        public ucAddPlaylist()
        {
            InitializeComponent();
        }

        private string playlistName;

        public string PlaylistName
        {
            get { playlistName = txtPlaylistName.Text; return playlistName; }
            set { playlistName = value; txtPlaylistName.Text = value; }
        }

        public event EventHandler AddBtnCreate_Click
        {
            add { btnCreate.Click += value; }
            remove { btnCreate.Click -= value; }
        }

        public event EventHandler AddBtnCancel_Click
        {
            add { btnCancel.Click += value; }
            remove { btnCancel.Click -= value; }
        }
    }
}
