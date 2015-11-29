using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int starCount = size - 2;
            int dotsCount = 1;
            string dots = new string('.', dotsCount);
            string star = new string('*',starCount);
            Console.WriteLine("\\{0}/" ,star);//first row
            starCount - 2;
            Console.WriteLine("{0}\\{1}/{0}",dots,new string(star,starCount)); //second row
            for (int i = 0; i <= size/2; i++)//third row
            {
                starCount - 2;
                Console.WriteLine("{0}\\{1}/{0}",
                    new string(dots,dotsCount),
                    new string(star,starCount));
            }
            Console.WriteLine("{0}",new string('-',size));


            
        }
    }
}
