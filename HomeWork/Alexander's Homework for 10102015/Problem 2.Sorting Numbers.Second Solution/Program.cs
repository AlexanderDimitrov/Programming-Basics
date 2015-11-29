using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Sorting_Numbers.Second_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write down a random number");
            int n = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[n];
            Console.WriteLine("Enter your {0} random numbers",n);
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write("Your Number = ");
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arrayNumbers);
            foreach (var item in arrayNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
