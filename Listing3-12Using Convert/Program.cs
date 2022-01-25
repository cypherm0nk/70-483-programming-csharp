using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_12Using_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringValue = "99";
            int intValue = Convert.ToInt32(stringValue);
            Console.WriteLine("intValue:{0}", intValue);

            stringValue = "True";
            bool boolvalue = Convert.ToBoolean(stringValue);
            Console.WriteLine("boolValue:{0}", boolvalue);

            Console.ReadKey();
        }
    }
}
