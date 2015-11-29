using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Sum_of_5_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            double forthNumber = double.Parse(Console.ReadLine());
            double fifthNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}",
                firstNumber , secondNumber, thirdNumber , forthNumber ,fifthNumber ,
                firstNumber + secondNumber + thirdNumber + forthNumber + fifthNumber);
        }
    }
}
