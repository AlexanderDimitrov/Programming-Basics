using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5.Calculate
{
    class Program
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("X = ");
            int x = int.Parse(Console.ReadLine());
            decimal resultX = 1;
            decimal factorialN = 1;
            decimal s = 0;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                resultX *= x;
                s += (factorialN / resultX);
            }
            Console.WriteLine(1 + s);
        }
    }
}
