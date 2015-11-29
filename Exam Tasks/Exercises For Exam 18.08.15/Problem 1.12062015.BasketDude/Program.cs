using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1._12062015.BasketDude
{
    class Program
    {
        static void Main(string[] args)
        {
            double fg = double.Parse(Console.ReadLine()); //field goals
            double fga = double.Parse(Console.ReadLine()); // field goal attempts
            double threePoints = double.Parse(Console.ReadLine());
            double turnovers = double.Parse(Console.ReadLine());
            double offensiveRebounds = double.Parse(Console.ReadLine());
            double oppoinentDefReb = double.Parse(Console.ReadLine());
            double ft = double.Parse(Console.ReadLine()); //free throws
            double fta = double.Parse(Console.ReadLine()); //free throw attepmts

            double efgp = (((fg) + 0.5*threePoints)/fga); //efective field goal percentage
            double tov = turnovers /(fga + 0.44*fta + turnovers); //turnover percentage 
            double orp = offensiveRebounds /(offensiveRebounds + oppoinentDefReb); //offensive rebound percentage
            double ftp = ft / fga;

            Console.WriteLine(efgp);
            Console.WriteLine(tov);
            Console.WriteLine(orp);
            Console.WriteLine(ftp);


        }
    }
}
