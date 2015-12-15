using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Gravitation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Weight: ");
            double a = double.Parse(Console.ReadLine());
            a = a * 0.17;
            Console.Write("Your weight on the moon is:");
            Console.WriteLine(a);
        }
    }
}
