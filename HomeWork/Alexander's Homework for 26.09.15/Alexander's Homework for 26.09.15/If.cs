using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexander_s_Homework_for_26._09._15
{
    class If
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the first IF Program :D");
            Console.WriteLine("Please enter random number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another random number");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                                
                Console.WriteLine("{0} {1}", b, a);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }
            else
            {
                Console.WriteLine("Thank you bye");
            }
            

        }
    }
}
