using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17.Dumbbell
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int dotsCount = (size / 2) - 1;
            int thingyCount = size / 2;
//Break The Task Into Several Pieces.
            //First Line- First And Last Piece of the Pie.
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.',size/2),
                new string('&',size /2 +1),
                new string('.',size));

            //Second Piece.Includes Lines
            for (int i = 0; i < size/2-1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                    new string('.',dotsCount),
                    new string('&',1),
                    new string('*',thingyCount),
                    new string('.',size));
                dotsCount--;
                thingyCount++;
            }
            //Third Piece.Middle Line.
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}",
                new string('&',1),
                new string('*',size -2),
                new string('=',size));
            //Forth Piece of the Puzzle
            int dotsCount1 = 1;
            int thingyCount1 = size - dotsCount1 -2;
            for (int i = 0; i < size / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                    new string('.', dotsCount1),
                    new string('&', 1),
                    new string('*', thingyCount1),
                    new string('.', size));
                dotsCount1++;
                thingyCount1--;
            }
            //Fifth and Last Piece of The Pie.Enjoy:)
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', size / 2),
                new string('&', size / 2 + 1),
                new string('.', size));



        }
    }
}
