using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Divide_by_7_and_5
{
    class Devider
    {
        static void Main(string[] args)
        {
            bool devider = false;
            double n;
            Console.WriteLine("Please enter a random number :");
            bool isDouble = double.TryParse(Console.ReadLine(),out n);

            if (isDouble)
            {
                if (n % 7 == 0 && n % 5 == 0)
                {
                    devider = true;
                }
                Console.WriteLine("The result of deviding is :{0}", devider);
            }            
            else
            {
                Console.WriteLine("Invalid Output Mon");
            }   
            Console.Read();
        }
    }
}
