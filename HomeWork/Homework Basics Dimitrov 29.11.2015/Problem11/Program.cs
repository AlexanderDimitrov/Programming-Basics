using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    
    class BankAccount
    {
        static void Main(string[] args)
        {

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Second Name: ");
            string middleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string thirdName = Console.ReadLine();
            Console.Write("Enter Your Desired Cash: ");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Your Bank Name: ");
            string bankName = Console.ReadLine();
            Console.Write("Enter Your IBAN: ");
            string iBAN = Console.ReadLine();
            Console.Write("Credit Card 1: ");
            long fCard = long.Parse(Console.ReadLine());
            Console.Write("Credit Card 2: ");
            long sCard = long.Parse(Console.ReadLine());
            Console.Write("Credit Card 3: ");
            long tCard = long.Parse(Console.ReadLine());

            Console.WriteLine("First Name: {0}",firstName);
            Console.WriteLine("Middle Name: {0}",middleName);
            Console.WriteLine("Last Name: {0}",thirdName);
            Console.WriteLine("Balance: {0}",balance);
            Console.WriteLine("Bank Name: {0}",bankName);
            Console.WriteLine("IBAN: {0}",iBAN);

            Console.WriteLine("First Credit Card Number :{0}",fCard);
            Console.WriteLine("First Credit Card Number :{0}",sCard);
            Console.WriteLine("First Credit Card Number :{0}",tCard);


        }
    }
}
