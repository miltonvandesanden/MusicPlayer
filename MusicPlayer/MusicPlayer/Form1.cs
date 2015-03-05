using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private MusicPlayer player;
        private List<Song> songs;
        private List<Playlist> playlists;
        private List<Artist> artists; 
        public Form1()
        {
            InitializeComponent();
            player = new MusicPlayer();

            songs = player.Songs;
            playlists = player.Playlists;
            artists = player.Artists;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Add Song to List
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            player.Add(new Song(tbSName.Text, (int)nudSYear.Value, (Artist)cbSArtist.Text, tbSPath.Text, rtbLyrics.Text));
        }

        //Add Artist
        private void btnAddArtist_Click(object sender, EventArgs e)
        {
        player.Add(new Artist(tbAName.Text, Convert.ToDateTime(dtpDateArtist)));
        }

        //Create Playlist
        private void btnPCreate_Click(object sender, EventArgs e)
        {
            player.Add(new Playlist(tbPName.Text));
        }

        //Add Song to Playlist
        private void btnPAddSong_Click(object sender, EventArgs e)
        {
            string songsName = lbPlaylist.SelectedItem.ToString();
            string playlistName = cbASPPlaylistName.ToString();
            foreach (Playlist playlist in playlists)
            {
                if (playlistName == playlist.Name)
                {
                    foreach (Song song in songs)
                    {
                        if (songsName == song.Name)
                        {
                            playlist.Add(song);
                        }
                    }
                }
            }
        }

        //Remove playlist
        private void btnPRemove_Click(object sender, EventArgs e)
        {
        
        }
    }
}
