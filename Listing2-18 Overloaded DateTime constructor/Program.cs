using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_18_Overloaded_DateTime_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d0 = new  DateTime(ticks: 636679008000000000);
            DateTime d1 = new DateTime(year:2019,month:8,day:24);
            Console.WriteLine(d0);
            Console.WriteLine(d1);
            Console.ReadKey();
        }
    }
}
