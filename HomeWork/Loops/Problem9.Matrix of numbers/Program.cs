using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9.Matrix_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
           int counter = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = i; j < a + i; j++)
                {
                    counter = j + 1;
                    Console.Write("{0,2}",counter);
                  
                    
                }
                Console.WriteLine();
               
            }
            
        }
    }
}
