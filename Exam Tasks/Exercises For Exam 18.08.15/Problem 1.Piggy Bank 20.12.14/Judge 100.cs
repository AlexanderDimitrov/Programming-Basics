using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Piggy_Bank_20._12._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfTank = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());
            if (partyDays > 8)
            {
                Console.WriteLine("never");
            }
            else
            {
                int savingDays = 30 - partyDays;
                int monthlysavings = savingDays * 2;
                int spendingDays = partyDays * 5;

                int cashier = (monthlysavings - spendingDays);
                double monthsToPay = (double)priceOfTank / cashier;
                int result = (int)Math.Ceiling(monthsToPay);
                int years = result / 12;
                int months = result % 12;
                Console.WriteLine("{0} years, {1} months" ,years , months);
            }

          

        }
    }
}
