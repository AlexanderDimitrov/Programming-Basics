using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13.Binary_to_Decimal_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary integer:");
            string binary = Console.ReadLine();
            int[] num = new int[binary.Length];
            long decimalNum = 0;
            long degree = binary.Length - 1;
            for (int i = 0; i < binary.Length; i++)
            {
                char ch = binary[i];
                num[i] = Convert.ToInt32(ch.ToString());
                decimalNum += num[i] * (long)Math.Pow(2, degree);
                degree--;
            }
            Console.WriteLine("{0}", decimalNum);
        }
    }
}
