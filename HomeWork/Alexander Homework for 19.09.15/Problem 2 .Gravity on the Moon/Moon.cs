using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Gravity_on_the_Moon
{
    class Moon
    {
        static void Main(string[] args)
        {
            double a = 0.17;
            Console.WriteLine("Please write down your weight:) :");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Your weight on the Moon is : {0} ", n * a);
            Console.WriteLine("Now please get back on Earth ,it's not safe.Have a nice day ,Bye :).");
            Console.ReadLine();



        }
    }
}
