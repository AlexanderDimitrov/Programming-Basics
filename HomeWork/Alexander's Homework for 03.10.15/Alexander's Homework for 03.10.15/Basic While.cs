using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexander_s_Homework_for_03._10._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            while (num <= n)
            {
                num++;
                Console.WriteLine("Number : {0}" , num -1);
                

            }
        }
    }
}
