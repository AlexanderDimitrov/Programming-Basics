using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var dec = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // we start with the least significant digit, and work our way to the left
                if (s[s.Length - i - 1] == '0') continue;
                dec += (int)Math.Pow(2, i);
            }
            Console.WriteLine(dec);
        }
    }
}
