using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_41_Get_an_enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringEnumerator = "Hello world".GetEnumerator();
            while (stringEnumerator.MoveNext())
            {
                Console.WriteLine(stringEnumerator.Current);
            }
            Console.ReadKey();
        }
    }
}
