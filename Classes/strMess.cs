using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicPlayer.Classes
{
    internal class strMess
    {

        /// <summary>
        /// String mess in home form
        /// </summary>
        public string existDownloadedTrack = "This track has been downloaded before !";
        public string typeSex = "Please choose your sex !";
        public string typeName = "Please type your name !";
        public string typeComment = "Please type your comment !";
        public string sendedComment = "Your comment was sended !";
        public string existedTrackInPlaylist = "This track has existed in this playlist";
        public string choosePlaylist = "Please choose a playlist !";

        /// <summary>
        /// String mess in search form
        /// </summary>
        public string notfoundTrack = "Track not found !";

        /// <summary>
        /// String mess in library form
        /// </summary>
        public string confirmDelPlaylist = "Delete this playlists ?";
        public string unableDelPlaylist = "Unable to delete this playlists !";
        public string deletedPlaylist = "Playlist has been deleted !";
        public string confirmRemoveTrackFromPlaylist = "Remove this track from this playlist ?";
        public string removedTrackFromPlaylist = "Track has been removed out of this playlist !";
        public string insertedPlaylist = "New playlists has been created !";
        public string existedPlaylistName = "Playlist name has existed, type another name !";
        public string emtyPlaylistName = "Please type playlists name !";
        public string removeAllTracks = "Remove all tracks in this playlist ?";
    }
}
