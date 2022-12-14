using IP007D_SpotifyManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP007D_SpotifyManager
{
    public partial class EditorUC : UserControl
    {
        SE22Context context = new SE22Context();

        public EditorUC()
        {
            InitializeComponent();
            PlaylistFilter();
            SongFilter();
            ListItems();
        }

        private void textBoxPlaylist_TextChanged(object sender, EventArgs e)
        {
            PlaylistFilter();
        }

        private void PlaylistFilter()
        {
            var playlist = from x in context.Playlist
                           where x.PlaylistName.Contains(textBoxPlaylist.Text)
                           select x;

            listBoxPlaylist.DataSource = playlist.ToList();
            listBoxPlaylist.DisplayMember = "PlaylistName";
        }

        private void textBoxSong_TextChanged(object sender, EventArgs e)
        {
            SongFilter();
        }

        private void SongFilter()
        {
            var song = from x in context.Song
                       where x.Track.Contains(textBoxSong.Text)
                       select x;

            listBoxSong.DataSource = song.ToList();
            listBoxSong.DisplayMember = "Track";
        }

        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItems();
        }

        private void ListItems()
        {
            var selected = (Playlist)listBoxPlaylist.SelectedValue;
            var connections = from x in context.Connect
                              where x.PlaylistFk == selected.PlaylistId
                              select new ConnectionDetail
                              {
                                  ConnectionId = x.ConnectId,
                                  Track = x.SongFkNavigation.Track,
                                  Artist = x.SongFkNavigation.Artist,
                                  Genre = x.SongFkNavigation.Genre
                              };

            connectionDetailBindingSource.DataSource = connections.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var sSong = (Song)listBoxSong.SelectedValue;
            var sPlaylist = (Playlist)listBoxPlaylist.SelectedValue;

            Connect newConnect = new Connect()
            {
                PlaylistFk = sPlaylist.PlaylistId,
                SongFk = sSong.SongId
            };

            context.Connect.Add(newConnect);
            context.SaveChanges();
            ListItems();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var selected = (ConnectionDetail)connectionDetailBindingSource.Current;

            var connectionDelete = (from x in context.Connect
                                   where x.ConnectId == selected.ConnectionId
                                   select x).FirstOrDefault();

            context.Connect.Remove(connectionDelete);
            context.SaveChanges();
            ListItems();
        }
    }
}
