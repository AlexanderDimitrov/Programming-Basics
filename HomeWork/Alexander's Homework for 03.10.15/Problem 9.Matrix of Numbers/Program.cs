using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Matrix_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer in the range (1 <= n <= 20):");
            int n = int.Parse(Console.ReadLine());
            int column = 1;

            if (n < 1 || n > 20)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int a = i; a < 2 * n; a++)
                {
                    if (column <= n)
                    {
                        Console.Write("{0} ", a);
                        column++;
                    }
                }
                Console.WriteLine();
                column = 1;
            }
        }
    }
}
