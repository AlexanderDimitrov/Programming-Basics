using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Quotes_in_Strings
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string firstSentance = @"The ""use"" of quotations causes difficulties.";
            string secondSentance = "The \"use\"  of quotations causes difficulties.";
            Console.WriteLine(firstSentance);
            Console.WriteLine(secondSentance);
        }
    }
}
