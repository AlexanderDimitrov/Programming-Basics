using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Join_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();

            string[] firstLineNums = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondLineNums = secondLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> mainList = new List<int>();
            List<int> secondList = new List<int>();
            for (int i = 0; i < firstLineNums.Length; i++)
            {
                secondList.Add(int.Parse(firstLineNums[i]));
            }
            for (int j = 0; j < secondLineNums.Length; j++)
            {
               secondList.Add(int.Parse(secondLineNums[j]));
            }


            mainList = secondList.Distinct().ToList();
            mainList.Sort();
            foreach (var number in mainList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
          }
        
    }
}
