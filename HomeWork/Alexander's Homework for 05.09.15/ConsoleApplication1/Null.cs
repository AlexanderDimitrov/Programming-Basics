using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Null
    {
        static void Main(string[] args)
        {
            int? someInteger = 0;
            double? someDouble = null;
            Console.WriteLine(someInteger);
            Console.WriteLine(someDouble);
        }
    }
}
