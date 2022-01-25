using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2._9_Calling_constructors
{
    class Program
    {
        class Alien
        {
            public int X;
            public int Y;
            public int Lives;
            public Alien(int x, int y, int lives) {
                if (x < 0 || y < 0)
                    throw new ArgumentOutOfRangeException("Invalid position");
                X = x;
                Y = y;
                Lives = lives;
            }
            public Alien(int x, int y) : this(x, y, 3) {

            }
            public override string ToString()
            {
                return string.Format("X: {0} Y:{1} Lives:{2}",X,Y,Lives);
            }

        }
        static void Main(string[] args)
        {
            Alien alien = new Alien(100,100);
            Console.WriteLine("Aliens {0}",alien.ToString());
            Console.ReadKey();
        }
    }
}
