using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Listing_3_2_Creating_XML
{
    public class MusicTrack
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public override string ToString()
        {
            return Artist + " " + Title + " " + Length.ToString() + " seconds long";
        }

        public MusicTrack()
        {

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
            MusicTrack track = new MusicTrack(artist: "Rob miles", title: "My Way", length: 150);
            XmlSerializer musicTrackSerializer = new XmlSerializer(typeof(MusicTrack));
            TextWriter serWriter = new StringWriter();
            musicTrackSerializer.Serialize(textWriter: serWriter, o: track);
            serWriter.Close();

            string trackXML = serWriter.ToString();
            Console.WriteLine("Track XML");
            Console.WriteLine(trackXML);

            TextReader serReader = new StringReader(trackXML);
            MusicTrack trackRead = musicTrackSerializer.Deserialize(serReader) as MusicTrack;
            Console.Write("Read back");
            Console.WriteLine(trackRead);
            Console.ReadKey();
        }
    }
}
