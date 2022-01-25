using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_5_Copy_construtor
{
    class MusicTrack
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public MusicTrack(MusicTrack source)
        {
            Artist = source.Artist;
            Title = source.Title;
            Length = source.Length;
        }
        public MusicTrack(string artist, string title, int length)
        {
            Artist = artist;
            Title = title;
            Length = length;
        }
    }
    class Program
    {
        static void PrintTrack(MusicTrack track) {
            track.Artist = "Fred Bloggs";
        }
        static void Main(string[] args)
        {
            MusicTrack track = new MusicTrack(artist:"Rob Miles",title:"My Way",length:120);
            PrintTrack(new MusicTrack(track));
            Console.WriteLine(track.Artist);
            Console.ReadKey();
        }
    }
}
