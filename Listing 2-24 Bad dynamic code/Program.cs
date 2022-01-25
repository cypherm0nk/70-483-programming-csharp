using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_24_Bad_dynamic_code
{
    class MessageDisplay
    {
        public void DisplayMessage(string message) {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MessageDisplay m = new MessageDisplay();
            m.DisplayMessage("Hello World");
            dynamic d = new MessageDisplay();
            d.Banana("hello world");
        }
    }
}
