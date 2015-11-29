﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.ODD_And_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers with a space between them:");
            string[] num = Console.ReadLine().Split();
            int sumOdd = 1;
            int sumEven = 1;
            for (int i = 0; i < num.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumOdd *= Convert.ToInt32(num[i]);
                }
                else
                {
                    sumEven *= Convert.ToInt32(num[i]);
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product={0}", sumOdd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product={0}", sumOdd);
                Console.WriteLine("even_product={0}", sumEven);
            }
        }
    }
}
