﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11.Random_Numbers_in_Given_Range
{
    class Randoms
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers for n, min and max, where (min ≤ max) :");
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            if (min > max)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int randomNumber = rnd.Next(min, max + 1);
                Console.Write("{0} ", randomNumber);
            }
            Console.WriteLine();
        }
    }
}
