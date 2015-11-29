using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dont know how to modify a format reading for dates, so use format - mm dd yyyy");
            //string date = "dd MM yyyy";
            DateTime j = DateTime.Parse(Console.ReadLine());
            DateTime a = DateTime.Parse(Console.ReadLine());

            double result = (j - a).TotalDays;
            Console.WriteLine(result);
            

        }
    }
}


