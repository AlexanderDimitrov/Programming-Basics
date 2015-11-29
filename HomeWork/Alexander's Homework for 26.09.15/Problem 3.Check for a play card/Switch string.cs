using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Check_for_a_play_card
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sign to check if it is a card :");
            string a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.WriteLine("Yes");
                    break;
                case "2":
                    Console.WriteLine("Yes");
                    break;
                case "3":
                    Console.WriteLine("Yes");
                    break;
                case "4":
                    Console.WriteLine("Yes");
                    break;
                case "5":
                    Console.WriteLine("Yes");
                    break;
                case "6":
                    Console.WriteLine("Yes");
                    break;
                case "7":
                    Console.WriteLine("Yes");
                    break;
                case "8":
                    Console.WriteLine("Yes");
                    break;
                case "9":
                    Console.WriteLine("Yes");
                    break;
                case "10":
                    Console.WriteLine("Yes");
                    break;
                case "A":
                    Console.WriteLine("Yes");
                    break;
                case "K":
                    Console.WriteLine("Yes");
                    break;
                case "Q":
                    Console.WriteLine("Yes");
                    break;
                case "J":
                    Console.WriteLine("Yes");
                    break;
                default: Console.WriteLine("No");
                    break;

            }
        }
    }

}
