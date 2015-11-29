using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Bonus_score
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            if ((a <= 3) & (a >= 1))
            {
                Console.WriteLine("{0}", a * 10);
            }

            else if ((a >= 4) & (a <= 6))
            {
                Console.WriteLine("{0}", a * 100);
            }

            else if ((a >= 7) & (a <= 9))
            {
                Console.WriteLine("{0}", a * 1000);
            }

            else if (a >= 10)
            {
                Console.WriteLine("Invalid score bro ,Bye!");
            }

            else if (a <= 0)
            {
                Console.WriteLine("Invalid score bro ,Bye!");
            }

            Console.WriteLine("Enjoy your day mate.");

            
        }
    }
}
