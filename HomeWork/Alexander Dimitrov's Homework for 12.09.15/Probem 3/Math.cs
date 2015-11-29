using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probem_3
{
    class Mathematics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter {0:F2}", 2 * Math.PI * radius);
            Console.WriteLine("Area {0:F2}",Math.PI*Math.Pow(radius,2));
        }
    }
}
