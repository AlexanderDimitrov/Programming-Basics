using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int i;
            long n1 = 0, n2 = 1, s;
            
            
            Console.Write(n1.ToString() + " " + n2.ToString() + " ");
            for (i = 1; i <= num - 2; i++)
            {
                s = n1 + n2;
                Console.Write(s.ToString() + " ");
                n1 = n2;
                n2 = s;
            }
            
        }
    }
}
