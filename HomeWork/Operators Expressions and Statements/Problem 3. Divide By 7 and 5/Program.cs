using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Divide_By_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 7 == 0 & a % 5 == 0)
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }
        }
    }
}
