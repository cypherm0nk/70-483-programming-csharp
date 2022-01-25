using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_46_The_serializable_attribute
{
    [Serializable]
    public class Person
    {
        public string Name;
        public int Age;
        [NonSerialized]
        private int screenPosition;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            screenPosition = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
