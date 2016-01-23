using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Exam_25._06._2015.Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            //width 2*size-1
            //hight 2*n+2
            //widnow Height size/2 | Width n-3
            //Top Line
            Console.WriteLine("{0}{1}{0}",
                new string('.',size -1),
                new string('*',1));

            int counter = size -2;
            int counter1 = 1;
            for (int i = 0; i < size - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('.',counter),
                    new string('*',1),
                    new string('.',counter1));
                counter--;
                counter1 = counter1 + 2;
            }
            //Middle Line
            Console.WriteLine("{0}",new string('*',2*size -1));
            //Bottom Half
            counter = size / 2;
            counter1 = size - 3;
            for (int i = 0; i < size/4; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('*',1)
                    ,new string('.',2*size - 3));
            }
            //Window
            for (int i = 0; i < size/2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('*',1),
                    new string('.',size/2),
                    new string('*',size -3));
            }
            for (int i = 0; i < size / 4; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('*', 1)
                    , new string('.', 2 * size - 3));

            }
            Console.WriteLine("{0}", new string('*', 2 * size - 1));
        }
    }
}
