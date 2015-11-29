using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Exam_20._12._14.Cheat_Sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
          
            long startRow = int.Parse(Console.ReadLine());
            long startCol = int.Parse(Console.ReadLine());

            for (long row = startRow; row < startRow + rows; row++)
            {
                for (long col = startCol; col < startCol + cols; col++)
                {
                    Console.Write(row * col);

                    if (col < startCol + cols -1)
                    {
                        Console.Write(' ');
                    }                                             
                }
                Console.WriteLine();
            }
        }
    }
}
