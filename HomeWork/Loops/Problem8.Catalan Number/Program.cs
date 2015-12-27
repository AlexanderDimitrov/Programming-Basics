﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8.Catalan_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n > 1 && n < 100)
            {
                long multiFactN = 1;
                long plusFactN = 1;
                long factN = 1;
                long result = 0;

                for (int i = 1; i <= 2 * n; i++)
                {
                    multiFactN *= i;
                }

                for (int j = 1; j <= n + 1; j++)
                {
                    plusFactN *= j;
                }

                for (int k = 1; k <= n; k++)
                {
                    factN *= k;
                }

                result = multiFactN / (plusFactN * factN);

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

    }
}
