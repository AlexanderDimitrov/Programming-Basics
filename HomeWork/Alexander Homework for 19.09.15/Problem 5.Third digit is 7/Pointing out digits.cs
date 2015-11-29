using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Third_digit_is_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number please :");
            int n = int.Parse(Console.ReadLine());
            int thirdDigit = (n / 10 / 10) % 10;
            bool check = thirdDigit == 7;
            Console.WriteLine("{0}", check);
            Console.ReadLine();
            
            
        }
    }
}
