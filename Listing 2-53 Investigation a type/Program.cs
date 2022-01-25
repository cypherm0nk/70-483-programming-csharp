using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Listing_2_53_Investigation_a_type
{
    class Person {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Type type;
            Person p = new Person();
            type = p.GetType();
            foreach (MemberInfo member in type.GetMembers())
            {
                Console.WriteLine(member.ToString());
            }
            Console.ReadKey();
        }
    }

}
