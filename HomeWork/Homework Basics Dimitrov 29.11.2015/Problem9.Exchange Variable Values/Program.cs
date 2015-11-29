using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 0;
            Console.WriteLine("{0}:{1}",a,b);
            c = b;
            b = a;
            a = c;
            Console.WriteLine("{0}:{1}",a,b);

        }
    }
}
