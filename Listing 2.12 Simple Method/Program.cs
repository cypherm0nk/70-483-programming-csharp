using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2._12_Simple_Method
{
    class Program
    {
        class Alien
        {
            public int X;
            public int Y;
            public int Lives;
            public Alien(int x, int y)
            {
                if (x < 0 || y < 0)
                    throw new ArgumentException("Invalid position");

                X = x;
                Y = y;
                Lives = 3;
            }

            public override string ToString()
            {
                return string.Format("X:{0} Y:{1} Lives: {2}", X, Y, Lives);
            }
            public bool RemoveLives(int livesToRemove)
            {
                Lives = Lives - livesToRemove;
                if (Lives <= 0)
                {
                    Lives = 0;
                    X = -1000;
                    Y = -1000;
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        static void Main(string[] args)
        {
            Alien x = new Alien(100,100);
            Console.WriteLine("X {0}",x);
            if (x.RemoveLives(2))
            {
                Console.WriteLine("Still alive");
            }
            else {
                Console.WriteLine("Alien destroyed");
            }
            Console.WriteLine("x {0}",x);
            Console.ReadKey();
        }
    }
}
