using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer
{
    public class Song
    {
        //fields

        /// <summary>
        /// artist resembles the artist that created the song
        /// </summary>
        private Artist artist;

        //properties

        /// <summary>
        /// Name contains the title of the song as a string variable
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Year contains the date wherein the song has been created as a datetime variable
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// PathToFile contains the path to the source file as a string variable
        /// </summary>
        public string PathToFile { get; set; }

        /// <summary>
        /// Lyrics contain the lyrics of the song as a string variable
        /// </summary>
        public string Lyrics { get; set; }

        //constructors

        /// <summary>
        /// The Song constructor initializes all the attributes of the Song class to the initial values, the initial values being the given parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <param name="artist"></param>
        /// <param name="pathOfFile"></param>
        /// <param name="lyrics"></param>
        public Song(string name, int year, Artist artist, string pathOfFile, string lyrics)
        {
            Name = name;
            Year = year;
            this.artist = artist;
            PathToFile = pathOfFile;
            Lyrics = lyrics;
        }

        //methods

        /// <summary>
        /// The ToString method returns all the attributes of the Song class added together as a string variable with a limiter between each attribute, the limiter being " : "
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "1 : " + Name + " # " + Year + " : " + artist + " : " + PathToFile + " : " + Lyrics;
        }
    }
}
