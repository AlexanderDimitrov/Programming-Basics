using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Play_with_int.Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choise for type :");
            Console.WriteLine("1 >> String");
            Console.WriteLine("2 >> Double");
            Console.WriteLine("3 >> Integer");
            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.WriteLine("Please enter a string");
                string str = (Console.ReadLine());
                str += "*";
                Console.WriteLine(str);
            }
            if (choise == 2)
            {
                Console.WriteLine("Please enter a random double : ");
                double a = double.Parse(Console.ReadLine());
                a = a + 1;
                Console.WriteLine(a);
            }
            if (choise == 3)
            {
                Console.WriteLine("Please enter a random integer");
                int b = int.Parse(Console.ReadLine());
                b = b + 1;
                Console.WriteLine(b);
            }



        }
    }
}
