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
    public partial class ucAddTrackIntoPLaylist : UserControl
    {
        public ucAddTrackIntoPLaylist()
        {
            InitializeComponent();
        }

        SqlAdapter sqlAdapter;

        private string playlistName;

        public string PlaylistName
        {
            get { return getCbPlaylistValue(); }
            set { playlistName = value; }
        }

        private string getCbPlaylistValue()
        {
            if(cbPlaylists.SelectedIndex > -1)
                return cbPlaylists.SelectedItem.ToString();

            return "";
        }

        public void setCbPlaylist()
        {
            cbPlaylists.Items.Clear();

            sqlAdapter = new SqlAdapter();
            DataTable playlists_dt = sqlAdapter.getAllPlaylists();

            if (playlists_dt.Rows.Count > 0)
            {
                foreach(DataRow row in playlists_dt.Rows)
                {
                    if (Int32.Parse(row[0].ToString()) == 0)
                        continue;

                    cbPlaylists.Items.Add(row[1].ToString());
                }
            }

            cbPlaylists.ResetText();

        }

        public event EventHandler AddBtnAdd_Click
        {
            add { btnAdd.Click += value; }
            remove { btnAdd.Click -= value; }
        }

        public event EventHandler AddBtnCancel_Click
        {
            add { btnCancel.Click += value; }
            remove { btnCancel.Click -= value; }
        }
    }
}
