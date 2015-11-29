using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());


            string[,] matrix = new string[height, width];

            for (int row = 0; row < height; row++)
            {
                int shiftedCol = row;
                for (int col = 0; col < width; col++)
                {
                    if (col == 0)
                    {
                        matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row) + (char)('a' + row);
                    }
                    else
                    {
                        matrix[row, col] = "" + (char)('a' + row) + (char)('a' + shiftedCol) + (char)('a' + row);
                    }
                    Console.Write(matrix[row, col] + " ");
                    shiftedCol++;
                }
                Console.WriteLine();
            }
        }
    }
}
