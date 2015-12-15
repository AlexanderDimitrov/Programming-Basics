using System;
using System.Text.RegularExpressions; //<<Using regex

namespace Problem_5.Third_digit_Is_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = int.Parse(Console.ReadLine());
            
            if (myInt.ToString().Length >= 3 && myInt.ToString()[myInt.ToString().Length - 3] == '7')
            {
                System.Console.WriteLine("True");
            }
            else
            {
                System.Console.WriteLine("False");
            }
        }
    }
}
