using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexander_s_Homework_for_10102015
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sortedArray = SortingNumbers(n);
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i] + " ");
            }
            Console.WriteLine();


        } 
        static int[] SortingNumbers(int count)
        {
            int[] arrayOfNumbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arrayOfNumbers);
            return arrayOfNumbers;
        }

    }
}
