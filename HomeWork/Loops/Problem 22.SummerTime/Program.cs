using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_22.SummerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            //Top
            Console.WriteLine("{0}" + "{1}",
                 new string(' ',((size *2)-(size+1))/2)
                ,new string('*',size + 1));
            //Top Half
            for (int i = 0; i < size/2 + 1; i++)
            {
                Console.WriteLine("{0}" + "{1}" + "{2}" + "{1}",
               new string(' ', ((size * 2) - (size + 1)) / 2),
               new string('*', 1),
               new string(' ', size - 1));
            }
            int counter = (((size*2) - (size+1))/2)-1;
            int counter1 = (size + 2)-1;
            for (int i = 0; i < size/2 -1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}",
                new string(' ',counter),
                new string('*',1),
                new string(' ', counter1));
                counter = counter - 1;
                counter1 = counter1+ 2;
                
            }
            //Middle
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                new string('*', 1),
                new string('.', size * 2 - 2));
            }
            //BottomHalf
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                new string('*', 1),
                new string('@', size * 2 - 2));
            }

            //Bottom
            Console.WriteLine("{0}",new string('*',size*2));
        }
    }
}
