﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.The_biggest_of_3_numbers
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
                Console.WriteLine(a);
            }
            else if ((b >= a) & (b >= c))
            {
                Console.WriteLine(b);
            }
            else if ((c >= a) & (c >= a))
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("My program doesnt work");
            }
        }
    }
}
