using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_20.Four_Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            double fieldGoals = double.Parse(Console.ReadLine());
            double fieldGoalAttempts = double.Parse(Console.ReadLine());
            double thirdPFieldGoals = double.Parse(Console.ReadLine());
            double turnovers = double.Parse(Console.ReadLine());
            double offensiveRebounds = double.Parse(Console.ReadLine());
            double OpponentDefensiveRebounds = double.Parse(Console.ReadLine());
            double freeThrows = double.Parse(Console.ReadLine());
            double freeThrowAttempts = double.Parse(Console.ReadLine());

            double eFG = (fieldGoals + 0.5 * thirdPFieldGoals) / fieldGoalAttempts; //EFG
            double turnoverP = turnovers / (fieldGoalAttempts + 0.44 * freeThrowAttempts + turnovers); //TOV%
            double offensiveReboundPercentage = offensiveRebounds / (offensiveRebounds + OpponentDefensiveRebounds); //RF%
            double freeThrowPercentage = freeThrows / fieldGoalAttempts;

            Console.WriteLine("eFG% {0:f3}", eFG);
            Console.WriteLine("TOV% {0:f3}", turnoverP);
            Console.WriteLine("ORB% {0:f3}", offensiveReboundPercentage);
            Console.WriteLine("FT% {0:f3}", freeThrowPercentage);
        }
    }
}
