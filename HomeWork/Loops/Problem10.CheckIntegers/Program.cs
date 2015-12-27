using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10.CheckIntegers
{
    class Program
    {
        static void Main(string[] args)
        { 
            string a =Console.ReadLine();
            string[] c = a.Split(' ');
            int[] myInts = Array.ConvertAll(c, int.Parse);
            int odd = 0;
            int evenNumbers = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if(myInts[i] % 2== 0 )
                {
                   evenNumbers = evenNumbers + myInts[i];
                   
                }
                else
                {
                    odd = odd + myInts[i];
                }
               
            }
            bool IsBigger = evenNumbers > odd;
            if(evenNumbers>odd)
            {
                Console.WriteLine("no");
                Console.WriteLine("even_product = {0} ", evenNumbers);
                Console.WriteLine("odd_product = {0}", odd);
            }
            if(evenNumbers<odd)
            {
                Console.WriteLine("no");
                Console.WriteLine("even_product = {0}", evenNumbers);
                Console.WriteLine("odd_product = {0}", odd);
            }
            else if(evenNumbers== odd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("Product = {0}", evenNumbers);
                
            }
          




        }
    }
}
