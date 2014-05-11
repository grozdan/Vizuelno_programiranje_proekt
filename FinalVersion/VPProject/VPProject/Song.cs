using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPProject
{
    [Serializable]
    public class Song
    {
        public string FileName { get; set; }
        public string Name { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Song(string fileName, int minutes, int seconds)
        {
            FileName = fileName;
            Name = FileName.Substring(FileName.LastIndexOf('\\') + 1);
            Minutes = minutes;
            Seconds = seconds;
        }
        public int getDurationInSeconds()
        {
            return Minutes * 60 + Seconds;
        }

        public override string ToString()
        {
            return string.Format("{0}  --->  {1:00}:{2:00}", Name, Minutes, Seconds);
        }
    }
}
