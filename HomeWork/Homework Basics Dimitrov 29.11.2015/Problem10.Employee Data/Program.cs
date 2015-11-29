using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10.Employee_Data
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("First Name: ");
        string a = Console.ReadLine();
        Console.Write("Last Name: ");
        string b = Console.ReadLine();
        Console.Write("Age: ");
        byte c = byte.Parse(Console.ReadLine());
        Console.Write("Gender: ");
        string d = Console.ReadLine();
        Console.Write("Personal ID: ");
        string e = Console.ReadLine();
        Console.Write("Unique Employee Number: ");
        long f = long.Parse(Console.ReadLine());

        Console.WriteLine("First Name: " + a);
        Console.WriteLine("Last Name: " + b);
        Console.WriteLine("Age: " + c);
        Console.WriteLine("Gender: " + d);
        Console.WriteLine("Personal ID: " + e);
        Console.WriteLine("Unique Employee Number: " + f);

    }
}
}
