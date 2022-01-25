using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Listing_2_54_Reflection_method_call
{
    class Person
    {
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Type type;

            Person p = new Person();
            type = p.GetType();
            MethodInfo setMethod = type.GetMethod("set_name");
            setMethod.Invoke(p, new object[] { "Fred" });
            Console.WriteLine(p.name);
            Console.ReadKey();
        }
    }
}
