using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Problem_10.Beer_Time
{
    class DateTimee
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a time in format " + "“" + "hh:mm tt" + "”:");
            System.DateTime time = System.DateTime.Parse(Console.ReadLine());
            System.DateTime startTime = System.DateTime.Parse("1:00 PM");
            System.DateTime endTime = System.DateTime.Parse("1:00 PM").AddHours(14);

            if ((time.Hour < 12))
            {
                time = time.AddDays(1);
            }

            if ((time >= startTime) && (time <= endTime))
            {
                Console.WriteLine("Beer Time!");
            }

            else
            {
                Console.WriteLine("No Beer Time for you!");
            }


        }
    }
}
