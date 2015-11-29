using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_after_10_Years
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime born = DateTime.Parse(Console.ReadLine());
            DateTime nowDate = DateTime.Now;
            int age = born.Year - nowDate.Year;
            age = -age;
            int age1 = age + 10;
            Console.WriteLine("Now :{0}",age);
            Console.WriteLine("After 10 years: {0}",age1);
            
        }
    }
}