using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14.ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Random Number");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Bit's Position");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Bit's Value");
            int v = int.Parse(Console.ReadLine());
            if (v==0)
            {
                int c = ~(1 << p);
                int d = n & c;
                Console.WriteLine(d);
            }
            else
            {
                int c = 1 << p;
                int d = n | c;
                Console.WriteLine(d);
            }


        }
    }
}
