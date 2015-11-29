using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers in range of 0 - 100 (1 < k < n < 100):");
            Console.WriteLine("N =");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("K =");
            double k = double.Parse(Console.ReadLine());

            if (k <= 1 || k > n || n <= 1 || n >= 100 || k >= 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            double factorialN = 1;
            double factorialK = 1;

            for (double i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
            }
            Console.WriteLine("{0}", factorialN / factorialK);
        }
    }
}
