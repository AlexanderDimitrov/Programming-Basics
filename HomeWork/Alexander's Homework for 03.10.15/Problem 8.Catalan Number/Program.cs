using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Catalan_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer in the range (1 < n < 100):");
            Int64 n = Int64.Parse(Console.ReadLine());
            Int64 Factorial2N = 1;
            Int64 FactorialN = 1;
            Int64 FacturialNPlus1 = 1;

            if (n == 1 || n >= 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            for (Int64 i = 1; i <= 2 * n; i++)
            {
                Factorial2N *= i;
                if (i <= n)
                {
                    FactorialN *= i;
                }
            }

            for (Int64 i = 1; i <= n + 1; i++)
            {
                FacturialNPlus1 *= i;
            }
            Console.WriteLine("{0}", Factorial2N / (FactorialN *
            FacturialNPlus1));
        }
    }
}
