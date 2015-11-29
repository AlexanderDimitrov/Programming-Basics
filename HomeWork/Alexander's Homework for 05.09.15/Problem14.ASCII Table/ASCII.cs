using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14.ASCII_Table
{
    class ASCII
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.ASCII;


            int column = 0;
            for (long counter = 32; counter < 128; counter++)
            {
                if (column == 0)
                {
                    Console.Write("0x{0:X}  ", counter);
                }
                Console.Write(" {0}  ", (char)counter);
                if (++column > 7)
                {
                    column = 0;
                    Console.WriteLine();
                }

            }
            Console.ReadLine();
        }
    }
}
