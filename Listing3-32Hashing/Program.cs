using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_32Hashing
{
    class Program
    {
        static void showHash(object source) {
            Console.WriteLine("Hash for {0} is: {1:X}",source,source.GetHashCode());
        }
        static void Main(string[] args)
        {
            showHash("Hello world");
            showHash("world Hello");
            showHash("Hemmm world");
            Console.ReadKey();
        }
    }
}
