using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12.Null_Values_ARithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullo = null;
            double? mullo = null;
            Console.WriteLine("Nullo at null value: " + nullo);
            Console.WriteLine("Mullo at null value: " + mullo);

            nullo += 5;
            mullo += 10;
            Console.WriteLine("nullo + 5 = {0}",nullo);
            Console.WriteLine("mullo + 10 = {0}",mullo);

            nullo = 687;
            mullo = 12098371.1231231;
            Console.WriteLine("Final null: ", nullo); //Taking the actual value but not showing it
            Console.WriteLine("Final mull: ",mullo);//Until we convert it to string .

          
            string mom = Convert.ToString(nullo);
            Console.WriteLine("Converted To string mom:{0}",mom); //Converted
            mom = "Mom";
            Console.WriteLine("After changing Mom's value :{0}",mom);
        }
    }
}
