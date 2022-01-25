using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2._10_Static_constructors
{
    class Program
    {
        class Alien {
            //Alien code here
            static Alien() {
                Console.WriteLine("Static Alien constructor running");
            }
        }
        static void Main(string[] args)
        {
            Alien alien = new Alien();
            Console.ReadKey();
        }
    }
}
