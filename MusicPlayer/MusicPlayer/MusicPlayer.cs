using System.Collections.Generic;

namespace MusicPlayer
{
    public class MusicPlayer
    {

        public MusicPlayer()
        {
        }

        public List<Song> Songs { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<Artist> Artists { get; set; }

        public void Add(Artist artist)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Song song)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Playlist playlist)
        {
            throw new System.NotImplementedException();
        }

        public void Play(Song song)
        {
            throw new System.NotImplementedException();
        }

        public void Play(Playlist platlist)
        {
            throw new System.NotImplementedException();
        }

        public void Playing()
        {
            throw new System.NotImplementedException();
        }

        public void StopPlaying()
        {
            throw new System.NotImplementedException();
        }
    }
}
