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
        //fields
        private MusicPlayer player;
        private List<Song> songs;
        private List<Playlist> playlists;
        private List<Artist> artists;

        /// <summary>
        /// constructors
        /// </summary>
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

        //events

        /// <summary>
        /// The btnAddSong_Click event adds a new instance of the Song class to the Player object and to the Artist object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            nudSYear.Value = 1890;

            btnAddSong.Enabled = false;
            cbSArtist.Enabled = false;
            rtbLyrics.Enabled = false;
            tbSPath.Enabled = false;
            nudSYear.Enabled = false;

            if (songs.Count > 0)
            {
                tbPName.Enabled = true;
            }
        }

        /// <summary>
        /// The btnAddArtist_Click event adds a new instance of the Artist class to the Player object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            player.Add(new Artist(tbAName.Text, Convert.ToDateTime(dtpDateArtist.Value)));
            RefreshSongList(songs, playlists);

            tbAName.Text = "";
            btnAddArtist.Enabled = false;

            if (artists.Count > 0)
            {
                tbSName.Enabled = true;
            }
        }

        /// <summary>
        /// the btnPCreate_Click event adds a new instance of the Playlist class to the player object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPCreate_Click(object sender, EventArgs e)
        {
            player.Add(new Playlist(tbPName.Text));
            tbPName.Text = "";
            RefreshSongList(songs, playlists);
        }

        /// <summary>
        /// The btnPAddSong_Click event adds a single new instance of the Song class to the playlist object if there is only one song given.
        /// If there is more than one song given this event will add all the songs to the playlist object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPAddSong_Click(object sender, EventArgs e)
        {
            string playlistName = Convert.ToString(cbASPPlaylistName.Text);

            if (libPlaylist.SelectedItems.Count == 1)
            {
                string songName = Convert.ToString(libPlaylist.SelectedItem);
                songName = songName.Substring(4, songName.IndexOf("#") - (songName.IndexOf(":") + 3));

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
                libPlaylist.Items.Add(playlist.ToString());
            }

            foreach (Song song in songs)
            {
                libPlaylist.Items.Add(song.ToString());
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

        //remove Song from playlist
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
                        songName = songName.Substring(4, songName.IndexOf("#") - (songName.IndexOf(":") + 3));

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
                nudSYear.Enabled = true;
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
                string songTag = Convert.ToString(libPlaylist.SelectedItem);
                songTag = songTag.Substring(0, 1);

                if (songTag == "1")
                {
                    cbASPPlaylistName.Enabled = true;
                } else if (songTag == "0")
                {
                    cbASPPlaylistName.Enabled = false;
                }
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

        private void nudSYear_ValueChanged(object sender, EventArgs e)
        {
            rtbLyrics.Enabled = true;
        }

        /// <summary>
        /// When clicked on the Playbutton there will be a check if the selected item a playlist is. If the item a playlist is the music player will play the list. If the item is a song the player will only play the selected song.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {

            string songTag = Convert.ToString(libPlaylist.SelectedItem);
            songTag = songTag.Substring(0, 1);

            if (songTag == "0")
            {
                string playlistName = Convert.ToString(libPlaylist.SelectedItem);
                playlistName = playlistName.Substring(4, playlistName.Count() - 4);

                foreach (Playlist item in playlists)
                {
                    if (item.Name == playlistName)
                    {
                        tbCurrentSong.Text = playlistName;
                        Status.Text = "Playing Playlist: " + playlistName;
                        player.Play(item);
                    }
                }
            }
            else if (songTag == "1")
            {
                string songName = Convert.ToString(libPlaylist.SelectedItem);
                songName = songName.Substring(4, songName.IndexOf("#") - (songName.IndexOf(":") + 3));
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
        }

        /// <summary>
        /// When clicked on the stop button the player will stop current playing song in the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            player.StopPlaying();
            tbCurrentSong.Text = "";
            Status.Text = "";
        }

        /// <summary>
        /// When clicked on the pause button the player will pause current playing song in the player
        /// Mostly unimplemented
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            Status.Text = "Paused";
            //todo create real pause function here
        }
    }
}