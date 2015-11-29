using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexander_Dimitrov_s_Homework_for_12._09._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your company's address?");
            string addressCompany = (Console.ReadLine());

            Console.WriteLine("What is your phone number?");
            string phoneNumber = (Console.ReadLine());

            Console.WriteLine("What is your fax number?");
            string faxNumber = (Console.ReadLine());

            Console.WriteLine("What is your website?");
            string webSite = (Console.ReadLine());

            Console.WriteLine("What is your manager's name?");
            string managerFirst = (Console.ReadLine());

            Console.WriteLine("What is your manager's second name?");
            string managerSecond = (Console.ReadLine());

            Console.WriteLine("What is your manager's age?");
            string managerAge = (Console.ReadLine());

            Console.WriteLine("What is your manager's phone?");
            string managerPhone = (Console.ReadLine());

            Console.WriteLine(addressCompany);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(faxNumber);
            Console.WriteLine(webSite);
            Console.WriteLine(managerFirst);
            Console.WriteLine(managerSecond);
            Console.WriteLine(managerAge);
            Console.WriteLine(managerPhone);

        }
    }
}
