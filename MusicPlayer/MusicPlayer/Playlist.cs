using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer
{
    public class Playlist
    {
        //properties
        public string Name
        {
            get;
            set;
        }

        public List<Song> Songs
        {
            get;
            set;
        }

        //constructors
        public Playlist(string name)
        {
            Name = name;
        }

        //methods
        public void Add(Song song)
        {
            Songs.Add(song);
        }

        public void Add(List<Song> songs)
        {
            foreach (Song song in songs)
            {
                Songs.Add(song);
            }
        }

        public void Remove(Song song)
        {
            foreach (Song noise in Songs)
            {
                if (noise.Name == song.Name)
                {
                    Songs.Remove(noise);
                }
            }
        }

        public string ToString()
        {
            string playlistString = Name;

            foreach (Song song in Songs)
            {
                playlistString += " : " + song.Name;
            }

            return playlistString;
        }
    }
}
