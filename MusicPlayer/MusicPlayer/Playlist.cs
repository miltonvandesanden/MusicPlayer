using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer
{
    public class Playlist
    {
        //properties

        /// <summary>
        /// The Name property contains the name of the playlist as a string variable
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The Songs property contains all the songs that are included in this playlist as a ListSong variable
        /// </summary>
        public List<Song> Songs
        {
            get;
            set;
        }

        //constructors

        /// <summary>
        /// The Playlist constructor initializes all the attributes to their initial values, the initial values being the given parameters
        /// </summary>
        /// <param name="name"></param>
        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }

        //methods

        /// <summary>
        /// The Add method adds one song, the song being the given parameter, to the list of songs called Songs
        /// </summary>
        /// <param name="song"></param>
        public void Add(Song song)
        {
            Songs.Add(song);
        }

        /// <summary>
        /// The Add method adds more every song in the list with songs, the list with songs being the given parameter, to the list with songs that is included in this class
        /// </summary>
        /// <param name="songs"></param>
        public void Add(List<Song> songs)
        {
            foreach (Song song in songs)
            {
                Songs.Add(song);
            }
        }

        /// <summary>
        /// The Remove method removes a song, the song being the given parameter, from the list with songs included in this class
        /// </summary>
        /// <param name="song"></param>
        public void Remove(Song song)
        {
            foreach (Song noise in Songs.ToList())
            {
                if (noise.Name == song.Name)
                {
                    Songs.Remove(noise);
                }
            }
        }

        /// <summary>
        /// The ToString method returns all the attributes of the Playlist class added together as a string variable with a limiter between each attribute, the limiter being " : "
        /// </summary>
        /// <returns></returns>
        public override string ToString()
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
