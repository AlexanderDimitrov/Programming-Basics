using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Modify

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the bit modifying program :)");
            Console.WriteLine("Eenter a random number :");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a random position of the bit");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value of the bit(1 or 0) :");
            int bitValue = int.Parse(Console.ReadLine());
          
            if      (bitValue == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine(result);
            }       
            
            else if (bitValue == 1)
            {
                int mask = 1 << p;
                int result = n | mask;
                Console.WriteLine(result);

                
            }
            else
            {
                Console.WriteLine("My program doesnt work :) ");
            }
            

        }
    }
}
