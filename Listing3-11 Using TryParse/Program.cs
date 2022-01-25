using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_11_Using_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            if (int.TryParse("99", out result))
                Console.WriteLine("This is a valid number. Result:"+result);
            else
                Console.WriteLine("This is not a valid number");

            Console.ReadKey();
        }
    }
}
