﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6.Calculate_N__K_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (n > 1 && k > 1 && n < 100 && k < 100)
            {
                long factN = 1;
                long factK = 1;
                long result = 0;

                for (int i = 1; i <= n; i++)
                {
                    factN *= i;
                }

                for (int j = 1; j <= k; j++)
                {
                    factK *= j;
                }

                result = factN / factK;

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
