using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_3_3_Validating_JSON
{
    class MusicTrack
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public override string ToString()
        {
            return Artist + " " + Title + " " + Length.ToString() + " seconds long";
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
        static void Main(string[] args)
        {
            string validJson= "{\"Artist\":\"Rob Miles\",\"Title\":\"My Way\",\"Length\":150\"}";
            try
            {
                MusicTrack trackRead = JsonConvert.DeserializeObject<MusicTrack>(validJson);
                Console.WriteLine("Read back: ");
                Console.WriteLine(trackRead);
            }
            catch (JsonReaderException e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
