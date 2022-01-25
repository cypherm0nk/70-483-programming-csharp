using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_17_Indexing_on_strings
{
    class Program
    {
        class NamedIntArray {
            //Create an array store the values
            public int[] array = new int[100];
            //Declare an indexer property
            public int this[string name] {
                get {
                    switch (name)
                    {
                        case "zero":
                            return array[0];
                        case "one":
                            return array[1];
                        default:
                            return -1;
                    }
                }
                set {
                    switch (name) {
                        case "zero":
                            array[0]=value;
                            break;
                        case "one":
                            array[1]=value;
                            break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            NamedIntArray x = new NamedIntArray();
            x["zero"] = 99;
            Console.WriteLine(x["zero"]);
            Console.ReadKey();
        }
    }
}
