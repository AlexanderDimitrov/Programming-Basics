using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow._18_appril_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dotsCount = (n -1)/2;
            //FIRST PART\/
            Console.WriteLine("{0}{1}{0}",                 
               new string('.',dotsCount),
               new string('#',n));
            //SECOND PART\/
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('.',dotsCount),
                    new string('#',1),
                    new string('.',n-2));
            }
            //THIRD PART
            Console.WriteLine("{0}{1}{0}",
                new string('#',(n/2+1)),
                new string('.',n-2));
            //FORTH PART n/2 -2
            int outSideD = 1;
            int inSideD = n + n - 5;
            for (int j = 0; j < n - 2; j++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('.',outSideD),
                    new string('#',1),
                    new string('.',inSideD));
                outSideD++;
                inSideD = inSideD -2;
            }
            Console.WriteLine("{0}{1}{0}",
                new string('.',(n + n -2)/2),
                new string('#',1));
        }
    }
}
