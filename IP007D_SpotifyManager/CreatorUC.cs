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
    public partial class CreatorUC : UserControl
    {
        SE22Context context = new SE22Context();

        public CreatorUC()
        {
            InitializeComponent();
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

        private void textBoxPlaylist_TextChanged(object sender, EventArgs e)
        {
            PlaylistFilter();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewPlaylistForm newPlaylistForm = new NewPlaylistForm();
            if (newPlaylistForm.ShowDialog() == DialogResult.OK)
            {
                Playlist newPlaylist = new Playlist()
                {
                    PlaylistName = newPlaylistForm.textBoxPlaylist.Text
                };

                context.Playlist.Add(newPlaylist);
                context.SaveChanges();
                PlaylistFilter();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You can only delete empty playlists. Are you sure you want to delete the selected playlist?", "Warning" , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                var selected = (Playlist)listBoxPlaylist.SelectedValue;

                var playlistDelete = (from x in context.Playlist
                                     where x.PlaylistId == selected.PlaylistId
                                     select x).FirstOrDefault();

                context.Playlist.Remove(playlistDelete);
                context.SaveChanges();
                PlaylistFilter();
            }
        }
    }
}
