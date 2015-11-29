using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13.Check_a_bit_at_given_Position
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


            if (bit == 1)
            {
                Console.WriteLine("True.The bit is 1");
            }
            else if (bit == 0)
            {
                Console.WriteLine("False.The bis is 0");
            }
            else
            {
                Console.WriteLine("My program doesnt work :D");
            }
            
        }
    }
}
