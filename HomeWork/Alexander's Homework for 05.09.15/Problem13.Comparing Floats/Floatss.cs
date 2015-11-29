using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13.Comparing_Floats
{
    class Floatss
    {
        static void Main()

        {
            double? someDouble = null;
            float firstNumber = 5.3f;
            float secondNumber = 6.1f;
            float difference = Math.Abs(firstNumber * 0.000001f);
            Console.WriteLine(firstNumber.Equals(secondNumber));
            if (Math.Abs(firstNumber - secondNumber) <= difference)
                Console.WriteLine("5.3 and 6.1.");
            else
                Console.WriteLine("5.3 and 6.1 are unequal.");
            Console.WriteLine(someDouble);
            Console.WriteLine(someDouble);


            float thirdNumber = 5.00000001f;
            float forthNumber = 5.00000003f;
            float differenceD = Math.Abs(thirdNumber * 0.000001f);
            Console.WriteLine(thirdNumber.Equals(forthNumber));
            if (Math.Abs(thirdNumber - forthNumber) <= differenceD)
                Console.WriteLine("5.00000001 and 5.00000003 are equal.");
            else
                Console.WriteLine("5.00000001 and 5.00000003 are unequal.");

            Console.WriteLine(someDouble);
            Console.WriteLine(someDouble);


            float fifthNumber = 5.00000005f;
            float sixthNumber = 5.00000001f;
            float differenceD1 = Math.Abs(fifthNumber * 0.000001f);
            Console.WriteLine(fifthNumber.Equals(sixthNumber));
            if (Math.Abs(fifthNumber - sixthNumber) <= differenceD1)
                Console.WriteLine("5.00000005 and 5.00000001 are equal.");
            else
                Console.WriteLine("5.00000005 and 5.00000001 are unequal.");

            Console.WriteLine(someDouble);
            Console.WriteLine(someDouble);


            float seventhNumber = -0.0000007f;
            float eightNumber = 0.0000007f;
            float differenceD2 = Math.Abs(seventhNumber * 0.000001f);
            Console.WriteLine(seventhNumber.Equals(eightNumber));
            if (Math.Abs(seventhNumber - eightNumber) <= differenceD2)
                Console.WriteLine("-0.0000007 and 0.0000007 are equal.");
            else
                Console.WriteLine("-0.0000007 and 0.0000007 are unequal");

            Console.WriteLine(someDouble);
            Console.WriteLine(someDouble);


            float number9 = -4.999999f;
            float number10 = -4.999998f;
            float differenceD3 = Math.Abs(number9 * 0.000001f);
            Console.WriteLine(number9.Equals(number10));
            if (Math.Abs(number9 - number10) <= differenceD3)
                Console.WriteLine("-4.999999 and -4.999998 are equal.");
            else
                Console.WriteLine("-4.999999 and -4.999998 are unequal");


            Console.WriteLine(someDouble);
            Console.WriteLine(someDouble);

            float number1 = 4.999999f;
            float number2 = 4.999998f;
            float differenceD4 = Math.Abs(number9 * 0.000001f);
            Console.WriteLine(number1.Equals(number2));
            if (Math.Abs(number1 - number2) <= differenceD3)
                Console.WriteLine("4.999999 and 4.999998 are equal.");
            else
                Console.WriteLine("4.999999 and 4.999998 are unequal");


















        }
    }

}


           
