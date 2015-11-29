using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Number_Comparer2
{
    class Mathematics

    {
        static void Main(string[] args)
        {
            double fNumber = double.Parse(Console.ReadLine());
            double sNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(fNumber >= sNumber ? fNumber : sNumber);
        }
    }
}
