using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Formating_Numbers
{
    class Formating
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number please:");
            Console.WriteLine("First Number = ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Number = ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Third Number = ");
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|", firstNumber);
            Console.WriteLine(Convert.ToString(firstNumber,2).PadLeft(10, '0') + "|");

            Console.WriteLine("{0,10:0.00}|", secondNumber);

            Console.WriteLine("{0,-10:0.000}|", thirdNumber);
            Console.WriteLine();


        }
    }
}
