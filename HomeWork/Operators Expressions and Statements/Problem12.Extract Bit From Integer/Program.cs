using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12.Extract_Bit_From_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Random Number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Bit's position to be extracted:");
            int b = int.Parse(Console.ReadLine());
            int c = a >> b;
            int bit = c & 1;
            Console.WriteLine("Bit at position {0} is : " + bit,b);
        }
    }
}
