﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Sort_3_Number_with_nested_ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if ((a >= b) & (a >= c))
            {
                if (b >= c)
                {
                    Console.WriteLine("{0} {1} {2}" , a, b, c);
                }
                else if (c >= b)
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else if ((b >= a) & (b >= c))
            {
                if (a >= c)
                {
                    Console.WriteLine("{0} {1} {2}" , b, a, c);
                }
                else if (c >= a)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            else if ((c >= a) & (c >= b))
            {
                if (a >= b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else if (b >= a)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
            else
            {
                Console.WriteLine("My program doesnt work");
            }
        }
    }
}