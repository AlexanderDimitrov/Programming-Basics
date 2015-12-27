using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.Decimal_to_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                // Get the integral value of the character.
                int value =int.Parse(Console.ReadLine());
                // Convert the decimal value to a hexadecimal value in string form.
                string hexOutput = string.Format("{0:X}", value);
                Console.WriteLine("Hexadecimal value of {0} is {1}",value, hexOutput);
            
        }
    }
}
