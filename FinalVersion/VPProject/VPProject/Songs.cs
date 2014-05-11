using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace VPProject
{
    [Serializable]

    public class Songs
    {
        public List<Song> songs { get; set; }

        public Songs()
        {
            songs = new List<Song>();
        }

        public void addSong(Song song)
        {
            songs.Add(song);
        }
    }
}
