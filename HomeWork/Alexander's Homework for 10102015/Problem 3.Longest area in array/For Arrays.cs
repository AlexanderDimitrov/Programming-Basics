using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Longest_area_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array [{0}] = " ,i);
                array[i] = Console.ReadLine();
            }
            int maxSequence = 0;
            string value = null;

            for (int i = 0; i < array.Length; i++)
            {
                int countSequence = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        countSequence++;
                        if (maxSequence < countSequence)
                        {
                            maxSequence = countSequence;
                            value = array[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("\nThe Element of maximal sequence is \"{0}\" ,repeated {1} times. " ,value ,maxSequence );
        }
    }
}
