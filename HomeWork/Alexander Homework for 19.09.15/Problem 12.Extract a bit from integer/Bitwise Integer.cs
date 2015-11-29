using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Extract_a_bit_from_integer
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a random number please :");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the desired bit you want to see :");
            int p = int.Parse(Console.ReadLine());

            int nRightP = n >> p;
            int bit = nRightP & 1;
            Console.WriteLine("The value of the #3 bit is : " + bit);
        }
    }
}
