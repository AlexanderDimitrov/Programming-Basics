using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_December_2014.Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fClassP = 7000;
            int bClassP = 3500;
            int eClassP = 1000;
            string[] fCPassengers = Console.ReadLine().Split();
            string[] bCPassengers = Console.ReadLine().Split();
            string[] eCPassengers = Console.ReadLine().Split();

            //First Class
            int firstClassIncome = (Convert.ToInt32(fCPassengers[0]) - Convert.ToInt32(fCPassengers[1])) * 7000;
            firstClassIncome += (int)(Convert.ToInt32(fCPassengers[1]) * (7000 * 0.3));
            firstClassIncome += (int)(Convert.ToInt32(fCPassengers[2])* (0.005 * 7000));
            //Second Class
            int secondClassIncome = (Convert.ToInt32(bCPassengers[0]) - Convert.ToInt32(bCPassengers[1])) * 3500;
            secondClassIncome += (int)(Convert.ToInt32(bCPassengers[1])* (3500 * 0.3));
            secondClassIncome += (int)(Convert.ToInt32(bCPassengers[2]) * (0.005 * 3500));
            //Economy class
            int economyClassIncome = (Convert.ToInt32(eCPassengers[0]) - Convert.ToInt32(eCPassengers[1])) * 1000;
            economyClassIncome += (int)(Convert.ToInt32(eCPassengers[1]) * (1000 * 0.3));
            economyClassIncome += (int)(Convert.ToInt32(eCPassengers[2]) * (0.005 * 1000));

            int totalIncome = firstClassIncome + secondClassIncome + economyClassIncome;
            int maxIncome = (int)(12 * 7000 + 12 * (0.005 * 7000)) + (int)(28 * 3500 + 28 * (0.005 * 3500)) + (int)(50 * 1000 + 50 * (0.005 * 1000));

            Console.WriteLine("{0}",totalIncome);
            Console.WriteLine("{0}",maxIncome - totalIncome);
        }
    }
}
