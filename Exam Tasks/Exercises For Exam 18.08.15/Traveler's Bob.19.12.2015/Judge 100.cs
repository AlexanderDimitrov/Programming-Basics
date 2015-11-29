using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler_s_Bob._19._12._2015
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();            
            int contractMonths = int.Parse(Console.ReadLine());
            int familyMonths = int.Parse(Console.ReadLine());

            int contractTravels = contractMonths * (4 * 3);
            int familyTravels = (2 * 2) * familyMonths;
            double normalTravels = (((12 - contractMonths - familyMonths) * 12) * 3 / 5.0);

            double totalT = contractTravels + familyTravels + normalTravels;

            if (year == "leap") 
            {
                totalT = (totalT * 0.05) + totalT;
            }
            Console.WriteLine((int)totalT);     
        }
    }
}
