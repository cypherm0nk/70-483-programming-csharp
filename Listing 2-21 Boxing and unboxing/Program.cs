using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_21_Boxing_and_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //the value 99 is boxed into a object
            object o = 99;
            int oVal = (int)o;
            Console.WriteLine(oVal);
            Console.ReadKey();

        }
    }
}
