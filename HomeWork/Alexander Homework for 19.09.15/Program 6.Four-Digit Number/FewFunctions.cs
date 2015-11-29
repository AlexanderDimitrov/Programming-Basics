using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6.Four_Digit_Number
{
    class FewFunctions
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int forthDigit = n % 10;
            int thirdDigit = (n / 10) % 10;
            int secondDigit = (n / 10 / 10) % 10;
            int firstDigit = (n / 10 / 10 / 10) % 10;

            int result1 = firstDigit + secondDigit + thirdDigit + forthDigit;
            Console.WriteLine(result1);
                       
            Console.WriteLine("{0}{1}{2}{3}", forthDigit , thirdDigit , secondDigit , firstDigit);

            Console.WriteLine("{0}{1}{2}{3}", forthDigit , firstDigit , secondDigit ,thirdDigit );

            Console.WriteLine("{0}{1}{2}{3}", firstDigit , thirdDigit , secondDigit , forthDigit);

            Console.ReadLine();


        }
    }
}
