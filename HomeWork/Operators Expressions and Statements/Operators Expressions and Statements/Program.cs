using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Expressions_and_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOdd = false;
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                isOdd = true;
                Console.WriteLine(isOdd);
            }
            else
            {
                Console.WriteLine(isOdd);
            }
        }
    }
}
