using System.Collections.Generic;

namespace MusicPlayer
{
    public class MusicPlayer
    {
        public List<Song> Songs { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<Artist> Artists { get; set; }

        public MusicPlayer()
        {
            Songs = new List<Song>();
            Playlists = new List<Playlist>();
            Artists = new List<Artist>();
        }

        public void Add(Artist artist)
        {
            Artists.Add(artist);
        }

        public void Add(Song song)
        {
           Songs.Add(song);          
        }

        public void Add(Playlist playlist)
        {
            Playlists.Add(playlist);
        }

        public void Play(Song song)
        {
            //todo
        }

        public void Play(Playlist platlist)
        {
            //todo
        }

        public void Playing()
        {
            //todo
        }

        public void StopPlaying()
        {
            //todo
        }
    }
}
