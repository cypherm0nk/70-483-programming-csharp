using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2._14_Named_parameters
{
    class Program
    {
        static int ReadValue(
            int low, //lowest allowed value
            int hight,//highest allowed value
            string prompt //prompt form the user
            )
        {
            return 1;

        }

        static void Main(string[] args)
        {
            int x = ReadValue(prompt: "Enter your age:",low:1,hight:100);
            Console.ReadKey();
        }
    }
}
