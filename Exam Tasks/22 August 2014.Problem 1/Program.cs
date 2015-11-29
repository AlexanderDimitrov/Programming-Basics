using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_August_2014.Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstBPackets = int.Parse(Console.ReadLine());
            int secondBPackets = int.Parse(Console.ReadLine());
            int thirdBPackets = int.Parse(Console.ReadLine());
            int forthBPackets = int.Parse(Console.ReadLine());
            int tableTops = int.Parse(Console.ReadLine());
            int tablesToMake = int.Parse(Console.ReadLine());
            //Calculating Legs
            int totalLegs = firstBPackets*1 + (secondBPackets * 2) + (thirdBPackets * 3) + (forthBPackets* 4);
            int legsForTables = totalLegs / 4;
            int legsLeft = totalLegs % 4;
            int topsLeft = tablesToMake - tableTops;

            //Calculating Tables
            int tables =((legsForTables + tableTops)/2);

            if (tables >tablesToMake)
            {
                topsLeft = -topsLeft;
                tables = tables - tablesToMake;
                Console.WriteLine("more: {0}", tables);
                Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);
            }
            else if (tables == tablesToMake)
            {
                Console.WriteLine("Just enough tables made: {0}", tablesToMake);
            }
            else if(tables < tablesToMake)
            {
                tables = tables - tablesToMake;
                legsLeft = (tablesToMake * 4) - totalLegs;
                if(legsLeft < 0)
                {
                    legsLeft = 0;
                }
                Console.WriteLine("less: {0}", tables);
                Console.WriteLine("tops needed: {0}, legs needed: {1}",topsLeft,legsLeft);
            }



        }
    }
}
