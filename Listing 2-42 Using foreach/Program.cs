using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_42_Using_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (char ch in "Hello World")
                Console.WriteLine(ch);
            Console.ReadKey();
        }
    }
}
