using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18.Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long factoriel = 1;
            int timesZero = 0;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
                
               
            }
            for (int i = 5; n / i >= 1; i *= 5)
            { timesZero += n / i; }
            Console.WriteLine(factoriel);      
            Console.WriteLine(timesZero);
        }
    }
}
