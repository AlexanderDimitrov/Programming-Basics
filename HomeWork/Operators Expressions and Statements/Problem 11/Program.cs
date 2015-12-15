using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());
            int bit = (int)(num >> 3) & 1;
            Console.WriteLine(bit);
        }
    }
}
