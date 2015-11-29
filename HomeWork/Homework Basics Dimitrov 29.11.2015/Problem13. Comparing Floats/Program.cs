using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double fNumber = double.Parse(Console.ReadLine());
            double sNumber = double.Parse(Console.ReadLine());

            double result = Math.Abs(fNumber - sNumber);
            if (result < 0.000001)
            {
                Console.WriteLine("True");
                Console.WriteLine("The difference of {0}",result);
            }
            else
            {

                Console.WriteLine("False");
                Console.WriteLine("The difference of {0} is too big ",result);


            }
            Console.WriteLine("Bye");
        }
    }
}
