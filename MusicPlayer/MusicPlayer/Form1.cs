using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Artist sArtist;
            foreach (Artist artist in artists)
            {
                if(cbSArtist.Text == artist.Name)
                {
                    sArtist = artist;

                    Song newSong = new Song(tbSName.Text, (int) nudSYear.Value, sArtist, tbSPath.Text, rtbLyrics.Text);
                    player.Add(newSong);

                    sArtist.Add(newSong);
                }
            }
            RefreshSongList(songs, playlists);

            tbSName.Text = "";
            cbSArtist.Text = "";
            rtbLyrics.Text = "";
            tbSPath.Text = "";

            btnAddSong.Enabled = false;
            cbSArtist.Enabled = false;
            rtbLyrics.Enabled = false;
            tbSPath.Enabled = false;
        }

        //Add Artist
        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            player.Add(new Artist(tbAName.Text, Convert.ToDateTime(dtpDateArtist.Value)));
            RefreshSongList(songs, playlists);

            tbAName.Text = "";
            btnAddArtist.Enabled = false;
        }

        //Create Playlist
        private void btnPCreate_Click(object sender, EventArgs e)
        {
            player.Add(new Playlist(tbPName.Text));
            tbPName.Text = "";
            RefreshSongList(songs, playlists);
        }

        //Add Song to Playlist
        private void btnPAddSong_Click(object sender, EventArgs e)
        {
            string playlistName = Convert.ToString(cbASPPlaylistName.Text);

            if (libPlaylist.SelectedItems.Count == 1)
            {
                string songName = Convert.ToString(libPlaylist.SelectedItem);
                songName = songName.Substring(0, songName.IndexOf(" :"));

                foreach (Playlist playlist in playlists)
                {
                    if (playlistName == playlist.Name)
                    {
                        foreach (Song song in songs)
                        {
                            if (songName == song.Name)
                            {
                                playlist.Add(song);
                            }
                        }
                    }
                }                
            } else if (libPlaylist.SelectedItems.Count > 1)
            {
                List<Song> addedSongs = new List<Song>();

                foreach (Object item in libPlaylist.SelectedItems)
                {
                    foreach (Song song in songs)
                    {
                        if (item == song.Name)
                        {
                            addedSongs.Add(song);
                        }
                    }
                }
                foreach (Playlist playlist in playlists)
                {
                    if (playlist.Name == playlistName)
                    {
                        playlist.Add(addedSongs);
                    }
                }
            }
            cbASPPlaylistName.Text = "";
            RefreshSongList(songs, playlists);
        }

        //Remove playlist
        private void btnPRemove_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Playlist playlist in playlists.ToList())
            {
                if (cbPRemove.Text == playlist.Name)
                {
                    playlists.RemoveAt(i);
                }
                i++;
            }

            cbPRemove.Text = "";
            RefreshSongList(songs, playlists);
        }

        //Refresh SongList List
        public void RefreshSongList(List<Song> songs, List<Playlist> playlists)
        {
            libPlaylist.Items.Clear();

            foreach (Playlist playlist in playlists)
            {
                libPlaylist.Items.Add(playlist.Name);
            }

            foreach (Song song in songs)
            {
                libPlaylist.Items.Add(song);
            }
        }

        private void cbRSFPPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRSFPPlaylist.SelectedIndex != -1)
            {
                cbRSFPSong.Enabled = true;
            }
            else
            {
                cbRSFPSong.Enabled = false;
            }
        }

        private void cbRSFPPlaylist_DropDown(object sender, EventArgs e)
        {
            cbRSFPPlaylist.Items.Clear();

            foreach (Playlist playlist in playlists)
            {
                cbRSFPPlaylist.Items.Add(playlist.Name);
            }
        }

        private void cbRSFPSong_DropDown(object sender, EventArgs e)
        {
            cbRSFPSong.Items.Clear();

            foreach (Playlist playlist in playlists)
            {
                if (playlist.Name == Convert.ToString(cbRSFPPlaylist.SelectedItem))
                {
                    foreach (Song song in playlist.Songs)
                    {
                        cbRSFPSong.Items.Add(song);
                    }
                }
            }
        }

        private void cbRSFPSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRSFPSong.SelectedIndex != -1)
            {
                btnRSFPRemove.Enabled = true;
            }
            else
            {
                btnRSFPRemove.Enabled = false;
            }
        }

        private void btnRSFPRemove_Click(object sender, EventArgs e)
        {
            string playlistName = Convert.ToString(cbRSFPPlaylist.SelectedItem);

            foreach (Playlist playlist in playlists)
            {
                if (playlist.Name == playlistName)
                {
                    foreach (Song song in songs)
                    {
                        string songName = Convert.ToString(cbRSFPSong.SelectedItem);
                        songName = songName.Substring(0, songName.IndexOf(" :"));
                        if (song.Name == songName)
                        {
                            playlist.Remove(song);
                        }
                    }
                }
            }
            RefreshSongList(songs, playlists);

            cbRSFPPlaylist.Items.Clear();
            cbRSFPSong.Items.Clear();
            cbRSFPPlaylist.Text = "";
            cbRSFPSong.Text = "";
        }

        private void cbSArtist_DropDown(object sender, EventArgs e)
        {
            cbSArtist.Items.Clear();

            foreach (Artist artist in artists)
            {
                cbSArtist.Items.Add(artist.Name);
            }
        }

        private void tbSName_TextChanged(object sender, EventArgs e)
        {
            if (tbSName.Text != "" && tbSName != null)
            {
                cbSArtist.Enabled = true;
            }
        }

        private void cbSArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSArtist.SelectedIndex != -1)
            {
                rtbLyrics.Enabled = true;
            }
        }

        private void rtbLyrics_TextChanged(object sender, EventArgs e)
        {
            if (rtbLyrics.Text != "" && rtbLyrics.Text != null)
            {
                tbSPath.Enabled = true;
            }
        }

        private void tbPName_TextChanged(object sender, EventArgs e)
        {
            if (tbPName.Text != "" && tbPName.Text != null)
            {
                btnPCreate.Enabled = true;
            }
        }

        private void cbASPPlaylistName_DropDown(object sender, EventArgs e)
        {
            cbASPPlaylistName.Items.Clear();

            foreach (Playlist playlist in playlists)
            {
                cbASPPlaylistName.Items.Add(playlist.Name);
            }
        }

        private void tbSPath_TextChanged(object sender, EventArgs e)
        {
            if (tbSPath.Text != "" && tbSPath.Text != null)
            {
                btnAddSong.Enabled = true;
            }
        }

        private void cbASPPlaylistName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPAddSong.Enabled = true;
        }

        private void libPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (libPlaylist.SelectedIndex != -1)
            {
                cbASPPlaylistName.Enabled = true;
            }
        }

        private void cbPRemove_DropDown(object sender, EventArgs e)
        {
            cbPRemove.Items.Clear();

            foreach (Playlist playlist in playlists)
            {
                cbPRemove.Items.Add(playlist.Name);
            }
            btnPRemove.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string songName = Convert.ToString(libPlaylist.SelectedItem);
            songName = songName.Substring(0, songName.IndexOf(" :"));
            
            foreach (Song item in songs)
            {
                if (item.Name == songName)
                {
                    tbCurrentSong.Text = songName;
                    Status.Text = "Playing";
                    player.Play(item);
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.StopPlaying();
            tbCurrentSong.Text = "";
            Status.Text = "";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Status.Text = "Paused";
            //todo create real pause function here
        }
    }
}