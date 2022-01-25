using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2._13_Extension_method
{
    using _13_Extension_method;
    class Program
    {
       
        static void Main(string[] args)
        {
            string text = @"A rocket explorer called wright,
            Once travelled much faster than light,
            He set out one day,
            In s relstive way,
            And returned on the previous night";
            Console.WriteLine(text.LineCount()); ;
            Console.ReadKey();
        }
    }
}
