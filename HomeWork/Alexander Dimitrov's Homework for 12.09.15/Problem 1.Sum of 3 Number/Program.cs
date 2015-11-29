using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sum_of_3_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} + {2} = {3} ", firstNumber , secondNumber , thirdNumber, firstNumber + secondNumber + thirdNumber);

          
        }
    }
}
