using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Extract_Urls_from_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            
            string http = "http://";
            string www = "www.";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(http) || words[i].Contains(www))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
