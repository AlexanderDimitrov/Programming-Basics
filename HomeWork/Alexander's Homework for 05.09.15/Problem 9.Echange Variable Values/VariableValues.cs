using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Echange_Variable_Values
{
    class VariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp = a;
            Console.WriteLine( "Before:");
            Console.WriteLine("a = 5", a);
            Console.WriteLine("b = 10", b);
            Console.WriteLine("After:");
            a = b;
            b = temp;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

        }
    }
}
