using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11.Bitwise_Extract_Bit
{
    class Bitwise
    {
        static void Main(string[] args)
        {
            int p = 3;
            Console.WriteLine("Enter a random number please :");
            int n = int.Parse(Console.ReadLine());               
            int nRightP = n >> p;     
            int bit = nRightP & 1;     
            Console.WriteLine("The value of the #3 bit is : " + bit);
        }
    }
}
