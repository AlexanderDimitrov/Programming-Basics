using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Prime_Number_Check
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a random number <=100 :");
            int num = int.Parse(Console.ReadLine());
            if (num <= 1)
            {
                Console.WriteLine("False!");
            }
            else if (num > 1 && num <= 100) 
            {
                if (num == 2 || num == 3 || num == 5 || num == 7)
                {
                    Console.WriteLine("True!");
                }
                else
                {
                    if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0 && num % 7 != 0) 
                    {
                        Console.WriteLine("True :)!");
                    }
                    else
                    {
                        Console.WriteLine("False!");
                    }
                }
            }

            else
            {
                Console.WriteLine("Invalid integer");
            }
        }
    }
}
