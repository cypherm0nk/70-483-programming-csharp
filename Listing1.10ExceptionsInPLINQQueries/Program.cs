using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1._10ExceptionsInPLINQQueries
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }
        public static bool CheckCity(string name)
        {
            if (name == "")
                throw new ArgumentException(name);
            return name == "Seattle";
        }
        static void Main(string[] args)
        {
            Person[] people = new Person[] {
                new Person{ Name="Alan",City="Hull"},
                new Person{ Name="Beryl",City="Seattle"},
                new Person{ Name="Charles",City="London"},
                new Person{ Name="David",City="Seattle"},
                new Person{ Name="Eddy",City="Paris"},
                new Person{ Name="Fred",City="Berlin"},
                new Person{ Name="Gordon",City="Hull"},
                new Person{ Name="Henry",City="Seattle"},
                new Person{ Name="Isaac",City="Seattle"},
                new Person{ Name="James",City="London"}
            };

            try
            {
                var result = from person in
                                  people.AsParallel()
                              where CheckCity(person.City)
                              select person;
                result.ForAll(person=>Console.WriteLine(person.Name));
            }
            catch (AggregateException e)
            {

                Console.WriteLine(e.InnerExceptions.Count+" Exceptions.");
            }

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

        }
    }
}
