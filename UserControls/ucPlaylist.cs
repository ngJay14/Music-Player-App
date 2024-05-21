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
    public partial class ucPlaylist : UserControl
    {
        public ucPlaylist()
        {
            InitializeComponent();
            WireAllControls(this);
        }

        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                if (ctl.Name == "btnDelete" || ctl.Name == "txtPlaylistName")
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

        private string playlistName;
        private int playlistId;

        public string PlaylistName
        {
            get { playlistName = txtPlaylistName.Text; return playlistName; }
            set { playlistName = value; txtPlaylistName.Text = setText(value); txtPlaylistName.ReadOnly = true; txtPlaylistName.Cursor = Cursors.Hand; }
        }

        public int PlaylistId
        {
            get { return playlistId; }
            set { playlistId = value; }
        }

        // Set text size if too long
        private string setText(string txt)
        {
            int txtLen = 25;
            if (txt.Length > txtLen)
            {
                txt = string.Concat(txt.Substring(0, txtLen), "...");
            }

            return txt;
        }

        public event EventHandler AddBtnDelete_Click
        {
            add { btnDelete.Click += value; }
            remove { btnDelete.Click -= value; }
        }

        private void txtPlaylistName_DoubleClick(object sender, EventArgs e)
        {
            if (playlistId == 0)
                return;

            txtPlaylistName.ReadOnly = false;
            txtPlaylistName.Cursor = Cursors.IBeam;
            txtPlaylistName.SelectAll();
        }

        private void txtPlaylistName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlAdapter sqlAdapter = new SqlAdapter();

                sqlAdapter.updatePlaylistNameById(playlistId, playlistName);

                txtPlaylistName.ReadOnly = true;
                txtPlaylistName.Cursor = Cursors.Hand;
            }
        }

        private void txtPlaylistName_TextChanged(object sender, EventArgs e)
        {
            playlistName = txtPlaylistName.Text;
        }
    }
}
