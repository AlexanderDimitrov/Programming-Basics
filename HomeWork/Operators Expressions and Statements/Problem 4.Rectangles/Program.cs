using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perimeter a2 + b2 /a*b Area
            Console.Write("Widght: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Perimerter: {0} ,Area: {1}",(a*2) + (b *2),a*b );
        }
    }
}
