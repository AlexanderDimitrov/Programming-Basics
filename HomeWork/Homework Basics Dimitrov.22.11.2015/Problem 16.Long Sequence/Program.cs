using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.Long_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1002; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("{0}",i);
                }
                else
                {
                    Console.WriteLine("{0}",-i);
                }
            }
        }
    }
}
