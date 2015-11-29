using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Calculate_N__devides_K_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers in range 0 - 100 (1 < k < n < 100):");
            Console.WriteLine("N=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("K=");
            int k = int.Parse(Console.ReadLine());

            if (k <= 1 || k > n || n <= 1 || n >= 100 || k >= 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            long factorialN = 1;
            int factorialK = 1;
            long factorialNK = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
            }

            for (int i = 1; i <= n - k; i++)
            {
                factorialNK *= i;
            }
            Console.WriteLine("{0}", factorialN /(factorialK * (factorialNK)));
        }
    }
}
