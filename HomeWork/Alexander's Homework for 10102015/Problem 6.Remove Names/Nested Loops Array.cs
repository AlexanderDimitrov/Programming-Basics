using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Remove_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            List<string> names = a.Split(' ').ToList();
            string namesToBeRemoved = Console.ReadLine();
            List<string> removedNames = namesToBeRemoved.Split(' ').ToList();
            for (int i = 0; i < removedNames.Count ; i++)
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (names.Contains(removedNames[i]))
                    {
                        names.Remove(removedNames[i]);
                    }
                }
            }
            foreach (var name in names)
            {
                Console.Write(name + ' ' );
            }
            Console.WriteLine();      
           
        }
    }
}
