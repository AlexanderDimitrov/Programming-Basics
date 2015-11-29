using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_7th_2014.Problem_1
{
    class Budget
    {
        static void Main(string[] args)
        {
            
            double rent = 150;
            double weekdays = 22;
            double totalCash = double.Parse(Console.ReadLine());
            double goingOutDays = double.Parse(Console.ReadLine());
            double homeDays = double.Parse(Console.ReadLine());

            weekdays = weekdays - goingOutDays;
            //Calculating
            double homeDCash = 160 - (homeDays * 40);
            double normalDCash = weekdays * 10;
            double goingDCash = goingOutDays * ((int)(totalCash * 0.03) + 10);
            double totalAmountSp = totalCash - normalDCash - goingDCash - homeDCash - 150 ;
            if(totalAmountSp > 0)
            {
                Console.WriteLine("Yes, leftover {0}.",totalAmountSp);
            }
            else if(totalAmountSp == 0)
            {
                Console.WriteLine("Exact Budget.");
            }
            else if(totalAmountSp < 0)
            {
                totalAmountSp = -totalAmountSp;
                Console.WriteLine("No, not enough {0}.",totalAmountSp);
            }
            



            

        }
    }
}
