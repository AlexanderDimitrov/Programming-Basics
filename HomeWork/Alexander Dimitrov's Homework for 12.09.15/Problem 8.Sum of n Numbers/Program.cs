using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Sum_of_n_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 'N' Number :");
            long n = long.Parse(Console.ReadLine());
            int i, sum = 0;
            int number = int.MinValue;
                for (i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("\nSum of N Numbers : " + sum);
            
        }
    }
}
