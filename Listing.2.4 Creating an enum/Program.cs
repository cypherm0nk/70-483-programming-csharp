using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing._2._4_Creating_an_enum
{
    class Program
    {

        enum AlienState {
            Sleeping,
            Attacking,
            Destroyed
        };
        static void Main(string[] args)
        {
            AlienState x = AlienState.Attacking;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
