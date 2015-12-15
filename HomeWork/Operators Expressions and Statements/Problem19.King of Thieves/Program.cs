using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19.King_of_Thieves
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char star = char.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}",
                new string('-',size/2),
                star);
            int charCount = 3;
            int dashCount = (size - 3) / 2;
            for (int i = 0; i < size / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('-',dashCount),
                    new string(star,charCount));
                charCount = charCount + 2;
                dashCount--;
            }
            Console.WriteLine(new string(star, size));

            int charCount1 = size -2;
            int dashCount1 = 1;
            for (int i = 0; i < size / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('-', dashCount1),
                    new string(star, charCount1));
                charCount1 = charCount1 - 2;
                dashCount1++;
            }
            Console.WriteLine("{0}{1}{0}",
                new string('-',(size/2)),
                new string(star,1));




        }
    }
}
