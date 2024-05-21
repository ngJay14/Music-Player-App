using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace musicPlayer.Classes
{
    internal class SqlAdapter
    {
        private string conns = "Data Source=HUUNGUYEN;Initial Catalog = musicPlayerApp; Integrated Security = True; Encrypt=False";
        private SqlDataAdapter adapter;

        // Queries of track table
        public DataTable getAllTracks()
        {
            adapter = new SqlDataAdapter("select * from [track]", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public DataTable getTrackByCategoryId(int category_id) 
        {
            string q = "select * from [track] where category = '"+ category_id + "'";

            adapter = new SqlDataAdapter(q, conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable findTracksByName(string name)
        {
            string q = "declare @name nvarchar(max);" +
                "set @name = '" + name + "';" +
                "select * from [track] where charindex (@name, name) > 0" +
                " or charindex (@name, singer) > 0";

            adapter = new SqlDataAdapter(q, conns);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;

        }

        public DataTable getTrackById(int id)
        {
            string q = "select * from [track] where id = '" + id + "'";

            adapter = new SqlDataAdapter(q, conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public void updateDownloadTrackById(int id, bool downloaded)
        {
            SqlConnection conn = new SqlConnection(conns);
            conn.Open();

            string q = "update [track]" +
                "set downloaded = @downloaded, " +
                "download_time = @download_time " +
                "where id = @id;";

            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@downloaded", downloaded);
            cmd.Parameters.AddWithValue("@download_time", DateTime.Now);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable getAllTracksDownloaded()
        {
            string q = "select * from [track] where downloaded = '" + 1 + "'";

            adapter = new SqlDataAdapter(q, conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DateTime getDownloadTimeByTrackId(int track_id)
        {
            DateTime downloadTime = new DateTime();

            string q = "select * from [track] where id = '"+ track_id +"' and downloaded = '" + 1 + "'";

            adapter = new SqlDataAdapter(q, conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    downloadTime = (DateTime)row[8];
                    break;
                }
            }

            return downloadTime;
        }

        // Queries of playlist table
        public DataTable getAllPlaylists()
        {
            adapter = new SqlDataAdapter("select * from [playlist]", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public int getIdOfLastPlaylist()
        {
            int id;

            adapter = new SqlDataAdapter("select top 1 * from [playlist] order by id desc", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            id = Int32.Parse(dt.Rows[0][0].ToString());

            return id;
        }

        public int getPlaylistIdByName(string playlistName) 
        {
            string q = "declare @name nvarchar(max);" +
                "set @name = '" + playlistName + "';" +
                "select * from [playlist] where name = @name";

            adapter = new SqlDataAdapter(q, conns);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    return Int32.Parse(row[0].ToString());
                }
            }

            return -1;
        }

        public bool checkPlaylistExistByName(string playlistName)
        {
            //string q = "declare @name nvarchar(max);" +
            //    "set @name = '" + playlistName + "';" +
            //    "select * from [playlist] where charindex (@name, name) > 0";

            string q = "select * from [playlist] where name = '"+ playlistName +"'";

            adapter = new SqlDataAdapter(q, conns);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;

            return false;
        }

        public int insertPlaylist(string playlistName)
        {
            SqlConnection conn = new SqlConnection(conns);
            conn.Open();

            int id = getIdOfLastPlaylist() + 1;

            string q = "insert into [playlist] (id, name) values (@id, @name)";

            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", playlistName);
            cmd.ExecuteNonQuery();

            conn.Close();

            return id;
        }

        public void deletePlaylistById(int id)
        {
            SqlConnection conn = new SqlConnection(conns);
            conn.Open();

            string q = "delete from [playlist] where id = @id";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable getPlaylistById(int id)
        {
            adapter = new SqlDataAdapter("select * from [playlist] where id = '"+ id +"'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public int[] getListTracksOfPlaylistById(int id)
        {
            DataTable playlists = getPlaylistById(id);

            if (playlists.Rows.Count > 0)
            {
                foreach (DataRow row in playlists.Rows)
                {
                    if (row[2].ToString() == string.Empty)
                        return null;
                    string trackList = row[2].ToString();

                    string[] s1 = trackList.Split(',');
                    int[] trackId_list = Array.ConvertAll(s1, n => int.Parse(n));

                    return trackId_list;
                }
            }

            return null;
        }

        public void updateTrackIdsById(int id, string track_ids)
        {
            SqlConnection conn = new SqlConnection(conns);
            conn.Open();

            string q = "update [playlist]" +
                "set track_ids = @track_ids " +
                "where id = @id;";

            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@track_ids", track_ids);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void insertTrackIdById(int id, int track_id)
        {
            int[] track_ids = getListTracksOfPlaylistById(id);

            if (track_ids == null)
                track_ids = new int[1];
            else
                Array.Resize(ref track_ids, track_ids.Length + 1);
            track_ids[track_ids.Length - 1] = track_id;

            string track_ids_str = string.Join(",", track_ids);

            updateTrackIdsById(id, track_ids_str);
        }

        public void removeTrackIdById(int id, int track_id)
        {
            int[] track_ids = getListTracksOfPlaylistById(id);

            track_ids = track_ids.Where(val => val != track_id).ToArray();

            string track_ids_str = string.Join(",", track_ids);

            updateTrackIdsById(id, track_ids_str);
        }

        public bool checkTrackInPlaylistById(int id, int track_id)
        {
            DataTable playlists = getPlaylistById(id);

            if (playlists.Rows.Count > 0)
            {
                foreach (DataRow row in playlists.Rows)
                {
                    if (row[2].ToString() == string.Empty)
                        return false;

                    string trackList = row[2].ToString();

                    string[] s1 = trackList.Split(',');
                    int[] trackId_list = Array.ConvertAll(s1, n => int.Parse(n));

                   if (trackId_list.Contains(track_id))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void updatePlaylistNameById(int playlistId, string name)
        {
            SqlConnection conn = new SqlConnection(conns);
            conn.Open();

            string q = "update [playlist]" +
                "set name = @name " +
                "where id = @id;";

            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", playlistId);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // // Queries of comment table

        public DataTable getAllComments()
        {
            adapter = new SqlDataAdapter("select * from [comment]", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable getAllCommentsByTrackId(int track_id)
        {
            adapter = new SqlDataAdapter("select * from [comment] where track_id = '"+ track_id +"'" +
                "order by time desc", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public void insertComment(int track_id, string name, string sex, string body, int rating, DateTime time)
        {
            SqlConnection conn = new SqlConnection(conns);
            conn.Open();

            string q = "insert into [comment] (track_id, name, sex, body, rating, time) values (@track_id, @name, @sex, @body, @rating, @time)";

            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@track_id", track_id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@body", body);
            cmd.Parameters.AddWithValue("@rating", rating);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public double getRatingCountByTrackId(int track_id)
        {
            double rating = 0;

            string q = "select * from [comment] where track_id = '" + track_id + "'";

            adapter = new SqlDataAdapter(q, conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    rating += Int32.Parse(row[4].ToString());
                }
            }

            return rating/dt.Rows.Count;
        }

    }
}
