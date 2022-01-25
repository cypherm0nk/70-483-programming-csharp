using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1._6InformingParallelization
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
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
            var result = from pearson in people.AsParallel().WithDegreeOfParallelism(4).WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                         where pearson.City == "Seattle"
                         select pearson;
            foreach (var pearson in result)
                Console.WriteLine(pearson.Name);

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

        }
    }

}
