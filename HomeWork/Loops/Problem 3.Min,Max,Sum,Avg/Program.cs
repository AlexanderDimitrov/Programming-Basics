using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Min_Max_Sum_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];
            for (int i = 0; i < a; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Sum = {0}",b.Sum());
            Console.WriteLine("Min = {0}",b.Min());
            Console.WriteLine("Max = {0}",b.Max());
            Console.WriteLine("Avg = {0:F2}",b.Average());
            
          
            
        }
    }
}
