using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
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
            if ((x >= -1 && x <= 5) && (y <= 1 && y >= -1))
            {
                Console.WriteLine("inside the rectangle");
            }
            else
            {
                Console.WriteLine("outside the rectangle");
            }
        }
    }
}
