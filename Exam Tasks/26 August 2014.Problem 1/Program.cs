using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_August_2014.Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matrix = new int[3,3];
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            long result = 0;
            if (x == 1)
            {

            }
            int position = x + 1;  // 1, 2, 3
            if (y == 1)
            {
                position = x + 4;  // 4, 5, 6
            }
            else if (y == 2)
            {
                position = x + 7;  // 7, 8, 9
            }
            v += position - 1;
            result = (long)Math.Pow(v, position);
            Console.WriteLine(result);



        }
    }
}
//