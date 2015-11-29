using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Print_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 101; i++)
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
