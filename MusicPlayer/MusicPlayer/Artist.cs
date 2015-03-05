using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer
{
    public class Artist
    {
        //fields
        private List<Song> songs;

        //properties
        public string Name
        {
            get;
            set;
        }

        public DateTime Birthday
        {
            get;
            set;
        }

        //constructors
        public Artist(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        //methods
        public void Add(Song song)
        {
            songs.Add(song);
        }

        public override string ToString()
        {
            string artistString = Name + " : " + Birthday;

            foreach (Song song in songs)
            {
                artistString += " : " + song.Name;
            }

            return artistString;
        }
    }
}
