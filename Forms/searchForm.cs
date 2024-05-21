using Guna.UI2.WinForms;
using musicPlayer.Classes;
using musicPlayer.UserControls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace musicPlayer
{
    public partial class searchForm : Form
    {
        int togMove;
        int mValx;
        int mValy;

        SqlAdapter sqlAdapter;
        ucTrackInfo3 trackInfo3;
        ucAddTrackIntoPLaylist addTrackIntoPLaylist_uc;
        int trackIdAddedPlaylist;
        strMess mess;

        public searchForm()
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

        // Form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            mess = new strMess();

            addTrackIntoPLaylist_uc = new ucAddTrackIntoPLaylist();
            addTrackIntoPLaylist_uc.setCbPlaylist();
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
            else if (btnNav.Name == "btnLibrary")
            {
                this.Hide();
                libraryForm form = new libraryForm();
                form.Show();
            }
            else if (btnNav.Name == "btnDownload")
            {
                this.Hide();
                downloadForm form = new downloadForm();
                form.Show();
            }
        }

        // Set search button click event
        private void btnSearchTracks_Click(object sender, EventArgs e)
        {

            if (txtSearch.Text == string.Empty)
            { return; }

            sqlAdapter = new SqlAdapter();

            DataTable dt = sqlAdapter.findTracksByName(txtSearch.Text);

            if (dt.Rows.Count > 0)
            {
                flPnFindedTracks.Controls.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    ucTrackInfo2 trackInfo2 = new ucTrackInfo2();
                    trackInfo2.TrackId = Int32.Parse(row[0].ToString());
                    trackInfo2.TrackImage = Image.FromFile(row[1].ToString());
                    trackInfo2.TrackName = row[3].ToString();
                    trackInfo2.SingerName = row[4].ToString();
                    trackInfo2.Liked = sqlAdapter.checkTrackInPlaylistById(0, trackInfo2.TrackId);

                    setBtnEventsOfTrack(trackInfo2);

                    flPnFindedTracks.Controls.Add(trackInfo2);
                }
            }
            else
            {
                MessageBox.Show(mess.notfoundTrack);
            }
        }

        /// <summary>
        /// Set button click events for ucTrackInfo2 items
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
                addTrackIntoPLaylist_uc.BringToFront();
            };
        }

        /// <summary>
        /// Set ucTrackInfo3 item which show details of a track
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

                foreach (ucTrackInfo2 track in flPnFindedTracks.Controls)
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
                        MessageBox.Show(mess.existDownloadedTrack);
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
    }
}