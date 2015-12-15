using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13.CheckBitAtGPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Random Number");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Bit's position to be checked if it is 1");
            int p = int.Parse(Console.ReadLine());
            bool isTrue = true;
            if(n>>p==1)
            {
                Console.WriteLine(isTrue);
            }
            else
            {
                Console.WriteLine(!isTrue);
            }
            

        }
    }
}
