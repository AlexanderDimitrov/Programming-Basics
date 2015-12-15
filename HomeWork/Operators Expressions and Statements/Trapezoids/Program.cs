using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h= int.Parse(Console.ReadLine());
            Console.WriteLine("{0}",((a + b)* h)/2);
        }
    }
}
