using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Hexademical_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexValue = Console.ReadLine();
            int decValue2 = Convert.ToInt32(hexValue, 16);
            Console.WriteLine(decValue2);
        }
    }
}
