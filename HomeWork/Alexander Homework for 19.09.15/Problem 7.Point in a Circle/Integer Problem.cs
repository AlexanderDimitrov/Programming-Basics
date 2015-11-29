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
            Console.WriteLine("Please write a random number x : ");
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine("Please write a random number y : ");
            float y = float.Parse(Console.ReadLine());

            bool insidePoint = (x * x) + (y * y) <= (2 * 2);
            Console.WriteLine("This points are inside the circle >>> " + insidePoint);

            
        }
    }
}
