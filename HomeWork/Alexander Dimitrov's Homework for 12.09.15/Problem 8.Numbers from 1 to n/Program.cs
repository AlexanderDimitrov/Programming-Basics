using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Numbers_from_1_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int firstNumber = int.Parse(Console.ReadLine());
                for (int i = 1; i <= firstNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }
            
            
        }
    }
}
