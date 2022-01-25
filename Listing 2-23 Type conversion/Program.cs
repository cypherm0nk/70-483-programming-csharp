using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_23_Type_conversion
{
    class Kilometers
    {
        public double Distance { get; }
        public Kilometers(double kilometers)
        {
            Distance = kilometers;
        }
    }
    class Miles
    {
        public double Distance { get; }
        //Conversion operator for implicit conversion to kilometers
        public static implicit operator Kilometers(Miles t)
        {
            Console.WriteLine("Implicit conversion from miles to kilometers");
            return new Kilometers(t.Distance * 1.6);
        }
        public static explicit operator int(Miles t) {
            Console.WriteLine("Explicit conversion from miles to int");
            return (int)(t.Distance + 0.5);
        }
        public Miles(double miles)
        {
            Distance = miles;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Miles m =new Miles(100);
            Kilometers k = m;
            Console.WriteLine("Kilometers:{0}", k.Distance);
            int intMiles = (int)m;
            Console.WriteLine("Int miles: {0}",intMiles);
            Console.ReadKey();

        }
    }
}
