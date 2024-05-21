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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace musicPlayer
{
    public partial class homeForm : Form
    {
        int togMove;
        int mValx;
        int mValy;

        SqlAdapter sqlAdapter;
        bool track_click = false;
        int trackIdAddedPlaylist;
        ucPlayer player_uc;
        ucTrackInfo3 trackInfo3;
        ucAddTrackIntoPLaylist addTrackIntoPLaylist_uc;
        List<int> recTrackList;

        strMess mess;


        public homeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Convert .txt file to Datatable
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="numberOfColumns"></param>
        /// <returns>Datatable</returns>
        public DataTable ConvertToDataTable(string filePath, int numberOfColumns)
        {
            DataTable tbl = new DataTable();

            for (int col = 0; col < numberOfColumns; col++)
                tbl.Columns.Add(new DataColumn("Column" + (col + 1).ToString()));


            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                var cols = line.Split('*');

                DataRow dr = tbl.NewRow();
                for (int cIndex = 0; cIndex < numberOfColumns; cIndex++)
                {
                    dr[cIndex] = cols[cIndex];
                }

                tbl.Rows.Add(dr);
            }

            return tbl;
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

        // Click event for back button in type tracks panel
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnTypeTracks.Visible = false;
        }

        /// <summary>
        /// Create uc items for types track flow layout panel in home page 
        /// with data get from data.txt file in bin/debug folder of project
        /// </summary>
        private void setUcTypeTrackItems()
        {
            DataTable typeDt = ConvertToDataTable("typeMusic\\data.txt", 3);

            sqlAdapter = new SqlAdapter();
            DataTable trackDt = sqlAdapter.getAllTracks();

            foreach (DataRow row in typeDt.Rows)
            {
                ucTypeTrack typeTrack = new ucTypeTrack();
                typeTrack.TxtType = row[0].ToString();
                typeTrack.TypeImage = Image.FromFile(row[1].ToString());

                // Set Click event for typeTrack uc
                typeTrack.Click += (sender, e) =>
                {
                    ucTypeTrackItems(Int32.Parse(row[2].ToString()), row[0].ToString());
                };

                flPnCategories.Controls.Add(typeTrack);
            }
        }

        /// <summary>
        /// Create uc items for recent tracks flow layout panel in home page 
        /// </summary>
        private void setUcRecTrackItems()
        {
            flPnRecTracks.Controls.Clear();

            recTrackList = ReadIntListFromFile("recent_tracks.txt");

            foreach (int recTrack in recTrackList)
            {
                DataTable track = sqlAdapter.getTrackById(recTrack);

                if (track.Rows.Count > 0)
                {
                    foreach (DataRow row in track.Rows)
                    {
                        ucTrackInfo1 trackInfo1 = new ucTrackInfo1();
                        trackInfo1.TrackId = Int32.Parse(row[0].ToString());
                        trackInfo1.TrackImage = Image.FromFile(row[1].ToString());
                        trackInfo1.TrackName = row[3].ToString();
                        trackInfo1.SingerName = row[4].ToString();

                        // Set Click event for recentTracks uc
                        trackInfo1.Click += (sender, e) =>
                        {
                            tracksPlayer.URL = "";
                            track_click = true;
                            setPlayer(Int32.Parse(row[0].ToString()), Image.FromFile(row[1].ToString()), row[3].ToString(), row[4].ToString(), row[2].ToString(), true);
                        };

                        flPnRecTracks.Controls.Add(trackInfo1);
                    }
                }
            }
        }

        /// <summary>
        /// Read a int list from .txt file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns> Int list </returns>
        public List<int> ReadIntListFromFile(string filePath)
        {
            // Read all lines from the file
            string allText = File.ReadAllText(filePath);

            // Split the text by comma and convert each segment to an integer
            List<int> intList = allText.Split(',')
                                    .Where(s => !string.IsNullOrWhiteSpace(s)) // Ensure no empty strings are processed
                                    .Select(s => int.Parse(s.Trim())) // Convert to integer
                                    .ToList(); // Convert the IEnumerable to an array

            return intList;
        }

        /// <summary>
        /// Update recent tracks file
        /// with data is id of track.
        /// This file include 5 elements as 5 ids of 5 trackss
        /// </summary>
        /// <param name="track_id"></param>
        private void setRecentTrackListFile(int track_id)
        {
            if (recTrackList.Contains(track_id)) return;

            else
            {
                recTrackList.RemoveAt(recTrackList.Count - 1);
                recTrackList.Insert(0, track_id);
            }
            // File path to save the list
            string filePath = "recent_tracks.txt";

            string recTracks_str = string.Join(",", recTrackList);

            // Writing the list to the file
            File.WriteAllText(filePath, recTracks_str);

        }

        /// <summary>
        /// Set items in flow panel when click into a type track items
        /// </summary>
        /// <param name="type_id"></param>
        /// <param name="title"></param>
        // Create uc items for Type Tracks flow layout panel
        private void ucTypeTrackItems(int type_id, string title)
        {
            flPnTypeTracks.Controls.Clear();
            pnTypeTracks.Visible = true;
            pnTypeTracks.BringToFront();

            player_uc.BringToFront();

            DataTable tracks = new DataTable();
            sqlAdapter = new SqlAdapter();

            if (type_id == 0)
            {
                lbTitle.Text = title;
                tracks = sqlAdapter.getAllTracks();
            }

            else
            {
                tracks = sqlAdapter.getTrackByCategoryId(type_id);
                lbTitle.Text = title + " type tracks";
            }


            foreach (DataRow row in tracks.Rows)
            {
                ucTrackInfo2 trackInfo2 = new ucTrackInfo2();
                
                trackInfo2.TrackId = Int32.Parse(row[0].ToString());
                trackInfo2.TrackImage = Image.FromFile(row[1].ToString());
                trackInfo2.TrackName = row[3].ToString();
                trackInfo2.SingerName = row[4].ToString();
                trackInfo2.Liked = sqlAdapter.checkTrackInPlaylistById(0, trackInfo2.TrackId);


                // Set Click event for recentTracks uc
                trackInfo2.Click += (sender, e) =>
                {
                    tracksPlayer.URL = "";
                    track_click = true;
                    setRecentTrackListFile(trackInfo2.TrackId);
                    setUcRecTrackItems();
                    setPlayer(Int32.Parse(row[0].ToString()), Image.FromFile(row[1].ToString()), row[3].ToString(), row[4].ToString(), row[2].ToString(), true);
                };

                trackInfo2.AddBtnInfoClick += (sender, e) =>
                {
                    setTrackInfo(trackInfo2.TrackId, trackInfo2.TrackImage, trackInfo2.TrackName, trackInfo2.SingerName, row[2].ToString());
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

                flPnTypeTracks.Controls.Add(trackInfo2);
            }
        }

        /// <summary>
        /// Set buttons click events for uc Player nav
        /// </summary>
        private void setBtnPlayer()
        {
            player_uc.AddBtnPlayClick += (sender, e) =>
            {
                if (tracksPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    tracksPlayer.Ctlcontrols.pause();
                }
                else
                {
                    tracksPlayer.Ctlcontrols.play();
                }

            };

            player_uc.AddBtnExitClick += (sender, e) =>
            {
                player_uc.Visible = false;
                tracksPlayer.URL = "";
            };

            player_uc.AddBtnInfoClick += (sender, e) =>
            {
                setTrackInfo(player_uc.TrackId, player_uc.TrackImage, player_uc.TrackName, player_uc.SingerName, string.Empty);
            };

            player_uc.AddBtnLikeClick += (sender, e) =>
            {
                if (player_uc.Liked)
                {
                    sqlAdapter.removeTrackIdById(0, player_uc.TrackId);
                    player_uc.Liked = false;
                }

                else
                {
                    sqlAdapter.insertTrackIdById(0, player_uc.TrackId);
                    player_uc.Liked = true;
                }
            };
        }

        /// <summary>
        /// Set ucTrackInfo3 item which show details of a track
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="trackImage"></param>
        /// <param name="trackName"></param>
        /// <param name="singerName"></param>
        /// <param name="trackURL"></param>
        private void setTrackInfo(int trackId, Image trackImage, string trackName, string singerName, string trackURL)
        {
            timer2.Interval = 100;
            timer2.Tick += Timer2_Tick;
            timer2.Start();

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
            trackInfo3.Rating = true;


            trackInfo3.AddBtnPlayClick += (sender, e) =>
            {
                    
                if (tracksPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    if (trackName == player_uc.TrackName && singerName == player_uc.SingerName)
                    {
                        tracksPlayer.Ctlcontrols.pause();
                    }
                    else
                    {
                        tracksPlayer.Ctlcontrols.stop();
                        track_click = true;
                        setPlayer(trackId, trackImage, trackName, singerName, trackURL, false);
                    }
                }
                else
                {
                    if (trackName == player_uc.TrackName && singerName == player_uc.SingerName)
                    {
                        tracksPlayer.Ctlcontrols.play();
                    }
                    else
                    {
                        tracksPlayer.Ctlcontrols.stop();
                        track_click = true;
                        setRecentTrackListFile(trackId);
                        setUcRecTrackItems();
                        setPlayer(trackId, trackImage, trackName, singerName, trackURL, false);
                    }
                }
            };

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

                foreach (ucTrackInfo2 track in flPnTypeTracks.Controls)
                {
                    track.Liked = sqlAdapter.checkTrackInPlaylistById(0, track.TrackId);
                }

                timer2.Stop();

                foreach(Control ctl in this.Controls)
                {
                    if(ctl is ucPanelComments)
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
        /// Timer tick event to check play button in trackInfo3 item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (tracksPlayer.playState == WMPLib.WMPPlayState.wmppsStopped || tracksPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
                trackInfo3.Played = false;

            else
            {
                if (player_uc.TrackName == trackInfo3.TrackName && player_uc.SingerName == trackInfo3.SingerName)
                    trackInfo3.Played = true;
                else
                    trackInfo3.Played = false;
            }
        }

        /// <summary>
        /// Set uc player nav 
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="trackImage"></param>
        /// <param name="trackName"></param>
        /// <param name="singerName"></param>
        /// <param name="trackURL"></param>
        /// <param name="visible"></param>
        private void setPlayer(int trackId, Image trackImage, string trackName, string singerName, string trackURL, bool visible)
        {

            sqlAdapter = new SqlAdapter();

            if (track_click)
            {
                track_click = false;
                player_uc.Visible = true;
                if (visible)
                    player_uc.BringToFront();

                player_uc.TrackId = trackId;
                player_uc.TrackImage = trackImage;
                player_uc.TrackName = trackName;
                player_uc.SingerName = singerName;
                player_uc.Liked = sqlAdapter.checkTrackInPlaylistById(0, trackId);
            }

            tracksPlayer.URL = trackURL;

        }

        /// <summary>
        /// Timer tick event to check play button in uc player nav item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Timer1_Tick(object sender, EventArgs e)
        {
            if (tracksPlayer.playState == WMPLib.WMPPlayState.wmppsStopped || tracksPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                player_uc.Played = false;

                //timer1.Stop();
            }
            else
                player_uc.Played = true;

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

        // Form load event
        private void homeForm_Load(object sender, EventArgs e)
        {
            setUcTypeTrackItems();
            setUcRecTrackItems();

            mess = new strMess();

            player_uc = new ucPlayer();
            this.Controls.Add(player_uc);
            player_uc.Location = new System.Drawing.Point(0, 704);
            player_uc.Visible = false;

            addTrackIntoPLaylist_uc = new ucAddTrackIntoPLaylist();
            addTrackIntoPLaylist_uc.setCbPlaylist();
            setBtnEventAddTrackIntoPlaylist_uc();

            this.Controls.Add(addTrackIntoPLaylist_uc);
            addTrackIntoPLaylist_uc.Location = new System.Drawing.Point(65, 245);
            addTrackIntoPLaylist_uc.Visible = false;


            timer1.Interval = 100;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            setBtnPlayer();
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
            var btnNav = (Guna2ImageButton) sender;

            if (btnNav.Name == "btnSearch")
            {
                tracksPlayer.Ctlcontrols.stop();
                this.Hide();
                searchForm form = new searchForm();
                form.Show();
            }
            else if (btnNav.Name == "btnLibrary")
            {
                tracksPlayer.Ctlcontrols.stop();
                this.Hide();
                libraryForm form = new libraryForm();
                form.Show();
            }
            else if (btnNav.Name == "btnDownload")
            {
                tracksPlayer.Ctlcontrols.stop();
                this.Hide();
                downloadForm form = new downloadForm();
                form.Show();
            }
        }
    }
}
