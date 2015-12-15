using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(number);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (number % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("{0}", prime);
        }
    }
}
