using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer
{
    public class Song
    {
        //fields
        private Artist artist;

        //properties
        public string Name { get; set; }

        public int Year { get; set; }

        public string PathToFile { get; set; }

        public string Lyrics { get; set; }

        //constructors
        public Song(string name, int year, Artist artist, string pathOfFile, string lyrics)
        {
            Name = name;
            Year = year;
            this.artist = artist;
            PathToFile = pathOfFile;
            Lyrics = lyrics;
        }

        //methods
        public override string ToString()
        {
            return Name + " : " + Year + " : " + artist + " : " + PathToFile + " : " + Lyrics;
        }
    }
}
