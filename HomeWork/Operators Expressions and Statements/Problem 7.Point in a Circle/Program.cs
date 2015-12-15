using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Point_in_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5)
            {
                Console.WriteLine("Inside the circle");
            }
            else
            {
                Console.WriteLine("Outside the Circle");
            }
          

        }
    }
}
