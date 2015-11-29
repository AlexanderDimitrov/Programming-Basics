using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Rectangles
{
    class AreaPerimeter
    {
        static void Main(string[] args)
        {
            double width;
            double hight;
            Console.WriteLine("Please write down the width of the Rectangle :");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write down the hight of the Rectangle :");
            hight = double.Parse(Console.ReadLine());
            
            Console.WriteLine("The perimeter of the desired Rectangle is :{0}",(width * 2) + (hight * 2));
            
            Console.WriteLine("The area of the desired Rectangle is : {0}",width * hight );
            Console.Read();
        }
    }
}
