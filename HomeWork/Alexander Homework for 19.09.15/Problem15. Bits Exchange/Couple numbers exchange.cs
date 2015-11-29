using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15.Bits_Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            /// NOT FINISHED !!!
            
            int n = int.Parse(Console.ReadLine());
            

            int mask = 1 << 3;
            int thirdBit = (n & mask) >> 3;

            
            mask = 1 << 24;
            int twentyFourthBit = (n & mask) >> 24;

            if (thirdBit == 0) // 3Bit Operatiobn
            {
                mask = ~(1 << 24);
                n = n & mask;
                  // 0 in 24 position

            }
            else if (thirdBit == 1)
            {
                mask = 1 << 24;
                n = n | mask;// 1 in 24 position

            }


            if (twentyFourthBit == 0) // 24bit Operation
            {
                mask = ~(1 << 3);
                n = n & mask;
                // 0 in 3 position

            }
            else if (twentyFourthBit == 1)
            {
                mask = 1 << 3;
                n = n | mask;
                // 1 in 3 position
            }
            Console.WriteLine(Convert.ToString(n,2).PadLeft(32, '0'));
            Console.WriteLine(n);

        }
    }
}
