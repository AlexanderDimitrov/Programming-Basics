using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());//First Half
            int starCount = size - 2;
            int dotsCount = 0;

            for (int i = 0; i < size/2; i++)
            {
                string dots = new string('.', dotsCount);
                string star = new string('*', starCount);
                Console.WriteLine("{0}\\{1}/{0}",dots,star);
                dotsCount++;
                starCount = starCount - 2;
            }
            if (size > 12) //Second Half
            {
                for (int j = 0; j < ((size/2) -2); j++)
                {
                    dotsCount = (size / 2) - 1;
                    Console.WriteLine("{0}||{0}",new string('.',dotsCount));
                }
            }
            else
            {
                for (int l = 0; l < (size/2)-1; l++)
                {
                    dotsCount = (size / 2) - 1;
                    Console.WriteLine("{0}||{0}",new string('.',dotsCount));
                }
            }

            int lastsize = size - ((size / 2) + ((size / 2) - 2));//Bottom of the glass
            if (size >= 12)
            {
                for (int i = 0; i < lastsize; i++)
                {
                    Console.WriteLine(new string('-', size));
                }
            }
            else
            {
                Console.WriteLine(new string('-',size));
            }
            



        }
    }
}
