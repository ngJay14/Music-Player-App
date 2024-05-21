using Guna.UI2.WinForms;
using musicPlayer.Classes;
using musicPlayer.UserControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace musicPlayer
{
    public partial class libraryForm : Form
    {
        int togMove;
        int mValx;
        int mValy;

        SqlAdapter sqlAdapter;
        ucAddPlaylist addPlaylist_uc;
        ucTrackInfo3 trackInfo3;
        ucAddTrackIntoPLaylist addTrackIntoPLaylist_uc;
        int trackIdAddedPlaylist;

        strMess mess;

        public libraryForm()
        {
            InitializeComponent();
        }

        // Set movement for this form using mouse
        private void homeForm_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            mValx = e.X;
            mValy = e.Y;
        }

        private void homeForm_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }

        private void homeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mValx, MousePosition.Y - mValy);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Set Delete playlist button click event
        /// </summary>
        /// <param name="playlist"></param>
        /// <returns> True if playlist has been deleted succesfully </returns>
        private bool btnDeletePlaylist_Click(ucPlaylist playlist)
        {
            DialogResult dialogResult = MessageBox.Show(mess.confirmDelPlaylist, "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                if (playlist.PlaylistId == 0)
                {
                    MessageBox.Show(mess.unableDelPlaylist);
                    return false;
                }

                sqlAdapter = new SqlAdapter();

                sqlAdapter.deletePlaylistById(playlist.PlaylistId);

                MessageBox.Show(mess.deletedPlaylist);

                flPnPlaylists.Controls.Remove(playlist);

                return true;
            }

            return false;

        }


        /// <summary>
        /// Set track items (ucTrackInfo2) when click into a playlist
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        private void playlistUc_Click(int id, string name)
        {
            sqlAdapter = new SqlAdapter();

            flPnPlaylistDetail.Controls.Clear();

            int[] track_ids = sqlAdapter.getListTracksOfPlaylistById(id);

            if ( track_ids != null)
            {
                foreach (int track_id in track_ids)
                {
                    DataTable track = sqlAdapter.getTrackById(track_id);

                    if (track.Rows.Count > 0)
                    {
                        foreach (DataRow row in track.Rows)
                        {
                            ucTrackInfo2 trackInfo2 = new ucTrackInfo2();

                            if (id == 0)
                                trackInfo2.disableBtnLike();

                            trackInfo2.TrackId = track_id;
                            trackInfo2.TrackImage = Image.FromFile(row[1].ToString());
                            trackInfo2.TrackName = row[3].ToString();
                            trackInfo2.SingerName = row[4].ToString();
                            trackInfo2.PlaylistBelong = true;
                            trackInfo2.Liked = sqlAdapter.checkTrackInPlaylistById(0, trackInfo2.TrackId);


                            trackInfo2.AddBtnDeleteClick += (sender, e) =>
                            {
                                DialogResult dialogResult = MessageBox.Show(mess.confirmRemoveTrackFromPlaylist, "Confirm", MessageBoxButtons.YesNo);

                                if (dialogResult == DialogResult.Yes)
                                {
                                    track_ids = track_ids.Where(val => val != track_id).ToArray();

                                    string track_ids_str = string.Join(",", track_ids);

                                    sqlAdapter.updateTrackIdsById(id, track_ids_str);

                                    MessageBox.Show(mess.removedTrackFromPlaylist);

                                    flPnPlaylistDetail.Controls.Remove(trackInfo2);
                                }
                            };

                            setBtnEventsOfTrack(trackInfo2);

                            flPnPlaylistDetail.Controls.Add(trackInfo2);
                        }
                    }

                }
            }

            lbPlaylistName.Text = name.ToString();
            pnPlaylistDetail.Tag = id;

            pnPlaylistDetail.Visible = true;
            pnPlaylistDetail.BringToFront();
        }


        /// <summary>
        /// Set track details (ucTrackInfo3) items
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="trackImage"></param>
        /// <param name="trackName"></param>
        /// <param name="singerName"></param>
        private void setTrackInfo(int trackId, Image trackImage, string trackName, string singerName)
        {
            sqlAdapter = new SqlAdapter();

            trackInfo3 = new ucTrackInfo3();
            this.Controls.Add(trackInfo3);
            trackInfo3.Location = new Point(0, 30);
            trackInfo3.Visible = false;

            trackInfo3.TrackId = trackId;
            trackInfo3.TrackImage = trackImage;
            trackInfo3.TrackName = trackName;
            trackInfo3.SingerName = singerName;
            trackInfo3.Liked = sqlAdapter.checkTrackInPlaylistById(0, trackId);

            trackInfo3.AddBtnLikeClick += (sender, e) =>
            {
                if (trackInfo3.Liked)
                {
                    sqlAdapter.removeTrackIdById(0, trackInfo3.TrackId);
                    trackInfo3.Liked = false;
                }

                else
                {
                    sqlAdapter.insertTrackIdById(0, trackInfo3.TrackId);
                    trackInfo3.Liked = true;
                }
            };

            trackInfo3.AddBtnBackClick += (sender, e) =>
            {
                sqlAdapter = new SqlAdapter();

                foreach (ucTrackInfo2 track in flPnPlaylistDetail.Controls)
                {
                    track.Liked = sqlAdapter.checkTrackInPlaylistById(0, track.TrackId);
                }

                foreach (Control ctl in this.Controls)
                {
                    if (ctl is ucPanelComments)
                    {
                        this.Controls.Remove(ctl);
                        ctl.Dispose();
                    }
                }

                trackInfo3.Visible = false;
            };

            trackInfo3.AddBtnAddIntoPlaylistClick += (sender, e) =>
            {
                trackIdAddedPlaylist = trackInfo3.TrackId;
                addTrackIntoPLaylist_uc.Visible = true;
                addTrackIntoPLaylist_uc.setCbPlaylist();
                addTrackIntoPLaylist_uc.BringToFront();
            };

            trackInfo3.AddBtnDownloadClick += (sender, e) =>
            {
                sqlAdapter = new SqlAdapter();
                DataTable dt = sqlAdapter.getTrackById(trackId);
                string trackPath = string.Empty;

                if (dt.Rows.Count > 0)
                {
                    if (bool.Parse(dt.Rows[0][7].ToString()))
                    {
                        MessageBox.Show("This track has been downloaded before !");
                        return;
                    }

                    trackPath = dt.Rows[0][2].ToString();
                }

                var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var assemblyParentPath = Path.GetDirectoryName(assemblyPath);
                var trackDir = Path.Combine(assemblyParentPath, trackPath);

                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "mp3|*.mp3|m4a|*.m4a|All files|.*";
                f.FilterIndex = 2;
                f.Title = "Save track";
                f.InitialDirectory = @"D:\Downloads";
                f.DefaultExt = "m4a";

                if (f.ShowDialog() == DialogResult.OK && f.FileName != "")
                {
                    File.Copy(trackDir, f.FileName);
                    sqlAdapter.updateDownloadTrackById(trackId, true);
                }
            };


            trackInfo3.Visible = true;
            trackInfo3.BringToFront();

            setPnComment(trackInfo3.TrackId);
        }

        /// <summary>
        /// Set comments panel in track detail item
        /// </summary>
        /// <param name="track_id"></param>
        private void setPnComment(int track_id)
        {
            sqlAdapter = new SqlAdapter();

            ucPanelComments pnCmts = new ucPanelComments();
            this.Controls.Add(pnCmts);
            pnCmts.Location = new System.Drawing.Point(0, 606);

            DataTable cmtDt = sqlAdapter.getAllCommentsByTrackId(track_id);

            pnCmts.setCommentItems(cmtDt);
            pnCmts.AddBtnAddCommentClick += (sender, e) =>
            {
                ucAddComment addComment_uc = new ucAddComment();
                this.Controls.Add(addComment_uc);
                addComment_uc.Location = new System.Drawing.Point(65, 245);
                addComment_uc.Visible = false;
                setBtnAddComment_Click(addComment_uc, pnCmts);

                addComment_uc.Track_id = track_id;
                addComment_uc.Visible = true;
                addComment_uc.BringToFront();

            };

            pnCmts.BringToFront();
        }

        /// <summary>
        /// Set click events for comments panel in trackInfo3 item
        /// </summary>
        /// <param name="addComment_uc"></param>
        /// <param name="pnCmts"></param>
        private void setBtnAddComment_Click(ucAddComment addComment_uc, ucPanelComments pnCmts)
        {
            addComment_uc.AddSendBtnLikeClick += (sender, e) =>
            {

                if (addComment_uc.Sex == "none")
                {
                    MessageBox.Show(mess.typeSex);
                    return;
                }

                if (addComment_uc.NameAuthor == string.Empty)
                {
                    MessageBox.Show(mess.typeName);
                    return;
                }

                if (addComment_uc.Body == string.Empty)
                {
                    MessageBox.Show(mess.typeComment);
                    return;
                }

                sqlAdapter = new SqlAdapter();

                sqlAdapter.insertComment(addComment_uc.Track_id, addComment_uc.NameAuthor, addComment_uc.Sex, addComment_uc.Body, addComment_uc.Rating, DateTime.Now);

                MessageBox.Show(mess.sendedComment);

                addComment_uc.Visible = false;
                this.Controls.Remove(addComment_uc);

                DataTable cmtDt = sqlAdapter.getAllCommentsByTrackId(addComment_uc.Track_id);
                pnCmts.setCommentItems(cmtDt);

            };

            addComment_uc.AddCancelBtnLikeClick += (sender, e) =>
            {
                addComment_uc.Visible = false;
                this.Controls.Remove(addComment_uc);
            };
        }

        /// <summary>
        /// Set click button events for ucTrackInfo2 items
        /// </summary>
        /// <param name="trackInfo2"></param>
        public void setBtnEventsOfTrack(ucTrackInfo2 trackInfo2)
        {
            trackInfo2.AddBtnInfoClick += (sender, e) =>
            {
                setTrackInfo(trackInfo2.TrackId, trackInfo2.TrackImage, trackInfo2.TrackName, trackInfo2.SingerName);
            };

            trackInfo2.AddBtnLikeClick += (sender, e) =>
            {
                if (trackInfo2.Liked)
                {
                    sqlAdapter.removeTrackIdById(0, trackInfo2.TrackId);
                    trackInfo2.Liked = false;
                }

                else
                {
                    sqlAdapter.insertTrackIdById(0, trackInfo2.TrackId);
                    trackInfo2.Liked = true;
                }
            };

            trackInfo2.AddBtnAddPlaylistClick += (sender, e) =>
            {
                trackIdAddedPlaylist = trackInfo2.TrackId;
                addTrackIntoPLaylist_uc.Visible = true;
                addTrackIntoPLaylist_uc.setCbPlaylist();
                addTrackIntoPLaylist_uc.BringToFront();
            };
        }

        /// <summary>
        /// Set playlist item for flow layout panel playlist
        /// </summary>
        private void setPlaylistItems()
        {
            sqlAdapter = new SqlAdapter();
            DataTable playlists = sqlAdapter.getAllPlaylists(); ;

            if (playlists.Rows.Count > 0)
            {
                foreach (DataRow row in playlists.Rows)
                {
                    ucPlaylist playlist = new ucPlaylist();
                    playlist.PlaylistId = Int32.Parse(row[0].ToString());
                    playlist.PlaylistName = row[1].ToString();

                    playlist.Click += (sender, e) =>
                    {
                        playlistUc_Click(playlist.PlaylistId, playlist.PlaylistName);
                    };

                    playlist.AddBtnDelete_Click += (sender, e) =>
                    {
                        btnDeletePlaylist_Click(playlist);
                    };

                    flPnPlaylists.Controls.Add(playlist);
                }
            }
        }

        /// <summary>
        /// Add new ucPlaylist item into playlists flow layout panel
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        private void addNewPlaylistIntoFlPanel(string name, int id)
        {
            ucPlaylist newPlaylist = new ucPlaylist();

            newPlaylist.PlaylistId = id;
            newPlaylist.PlaylistName = name;

            newPlaylist.Click += (sender, e) =>
            {
                playlistUc_Click(newPlaylist.PlaylistId, newPlaylist.PlaylistName);

            };

            newPlaylist.AddBtnDelete_Click += (sender, e) =>
            {
                btnDeletePlaylist_Click(newPlaylist);
            };

            flPnPlaylists.Controls.Add(newPlaylist);
        }

        /// <summary>
        /// Set button click events for add playlist panel
        /// </summary>
        private void setBtnEventAddPlaylist_uc()
        {
            addPlaylist_uc.AddBtnCreate_Click += (sender, e) =>
            {
                sqlAdapter = new SqlAdapter();

                if (addPlaylist_uc.PlaylistName != string.Empty)
                {
                    if (!sqlAdapter.checkPlaylistExistByName(addPlaylist_uc.PlaylistName))
                    {
                        int id = sqlAdapter.insertPlaylist(addPlaylist_uc.PlaylistName);

                        MessageBox.Show(mess.insertedPlaylist);

                        // Add new playlists item into flow layput panel
                        addNewPlaylistIntoFlPanel(addPlaylist_uc.PlaylistName, id);

                        addPlaylist_uc.Visible = false;
                        addPlaylist_uc.PlaylistName = string.Empty;
                    }
                    else
                        MessageBox.Show(mess.existedPlaylistName);
                    
                }
                else
                    MessageBox.Show(mess.emtyPlaylistName);

            };

            addPlaylist_uc.AddBtnCancel_Click += (sender, e) =>
            {
                addPlaylist_uc.PlaylistName = string.Empty;
                addPlaylist_uc.Visible = false;
            };
        }

        // Form load event
        private void libraryForm_Load(object sender, EventArgs e)
        {
            setPlaylistItems();

            mess = new strMess();

            addPlaylist_uc = new ucAddPlaylist();
            addPlaylist_uc.PlaylistName = string.Empty;
            setBtnEventAddPlaylist_uc();

            this.Controls.Add (addPlaylist_uc);
            addPlaylist_uc.Location = new System.Drawing.Point(65, 245);
            addPlaylist_uc.Visible = false;

            pnPlaylistDetail.Visible = false;

            addTrackIntoPLaylist_uc = new ucAddTrackIntoPLaylist();
            setBtnEventAddTrackIntoPlaylist_uc();

            this.Controls.Add(addTrackIntoPLaylist_uc);
            addTrackIntoPLaylist_uc.Location = new System.Drawing.Point(65, 245);
            addTrackIntoPLaylist_uc.Visible = false;
        }

        /// <summary>
        /// Set click events for uc add_track_into_playlist panel item
        /// </summary>
        private void setBtnEventAddTrackIntoPlaylist_uc()
        {
            addTrackIntoPLaylist_uc.AddBtnAdd_Click += (sender, e) =>
            {
                sqlAdapter = new SqlAdapter();

                int choosenPlistId = sqlAdapter.getPlaylistIdByName(addTrackIntoPLaylist_uc.PlaylistName);

                if (addTrackIntoPLaylist_uc.PlaylistName != "")
                {
                    if (!sqlAdapter.checkTrackInPlaylistById(choosenPlistId, trackIdAddedPlaylist))
                    {
                        sqlAdapter.insertTrackIdById(choosenPlistId, trackIdAddedPlaylist);

                        MessageBox.Show($"This track has added into {addTrackIntoPLaylist_uc.PlaylistName} playlist !");

                        trackIdAddedPlaylist = -1;
                        addTrackIntoPLaylist_uc.setCbPlaylist();
                        addTrackIntoPLaylist_uc.Visible = false;
                    }
                    else
                        MessageBox.Show(mess.existedTrackInPlaylist);
                }
                else
                    MessageBox.Show(mess.choosePlaylist);
            };

            addTrackIntoPLaylist_uc.AddBtnCancel_Click += (sender, e) =>
            {
                addTrackIntoPLaylist_uc.setCbPlaylist();
                addTrackIntoPLaylist_uc.Visible = false;
            };
        }

        // Set add playlist button click event
        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            addPlaylist_uc.Visible = true;
            addPlaylist_uc.PlaylistName = string.Empty;
            addPlaylist_uc.BringToFront();
        }

        // Set delete button click event in playlist detail panel
        private void btnDeletePlaylistDetails_Click(object sender, EventArgs e)
        {
            sqlAdapter = new SqlAdapter();
            ucPlaylist playlist = new ucPlaylist();

            DataTable playlists = sqlAdapter.getPlaylistById(Int32.Parse(pnPlaylistDetail.Tag.ToString()));

            if(playlists.Rows.Count > 0)
            {
                foreach(DataRow row in playlists.Rows)
                {
                    playlist.PlaylistId = Int32.Parse(row[0].ToString());
                    playlist.PlaylistName = row[1].ToString();
                }
            }

            if (btnDeletePlaylist_Click(playlist))
            {
                flPnPlaylists.Controls.Clear();
                setPlaylistItems();

                pnPlaylistDetail.Visible = false;
            }
        }

        // Set back button click event 
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnPlaylistDetail.Visible = false;
        }

        // Nav bar button click events
        private void btnNavbar_Click(object sender, EventArgs e)
        {
            var btnNav = (Guna2ImageButton)sender;

            if (btnNav.Name == "btnHome")
            {
                this.Hide();
                homeForm form = new homeForm();
                form.Show();
            }
            else if (btnNav.Name == "btnSearch")
            {
                this.Hide();
                searchForm form = new searchForm();
                form.Show();
            }
            else if (btnNav.Name == "btnDownload")
            {
                this.Hide();
                downloadForm form = new downloadForm();
                form.Show();
            }
        }

        // Set delete all tracks in playlist button click event
        private void btnDeleteAllTracks_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(mess.removeAllTracks, "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                sqlAdapter = new SqlAdapter();

                sqlAdapter.updateTrackIdsById(Int32.Parse(pnPlaylistDetail.Tag.ToString()), "");

                playlistUc_Click(Int32.Parse(pnPlaylistDetail.Tag.ToString()),lbPlaylistName.Text);

            }
        }
    }
}
