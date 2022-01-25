using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2._16_Indexed_properties
{
    class Program
    {
        class IntArrayWrapper {
            //Create an array to store the values
            private int[] array = new int[100];
            //declare an indexer property
            public int this[int i] {
                get { return array[i]; }
                set { array[i] = value; }
            }
        }
        static void Main(string[] args)
        {
            IntArrayWrapper x = new IntArrayWrapper();
            x[0] = 99;
            Console.WriteLine(x[0]);
            Console.ReadKey();
        }
    }
}
