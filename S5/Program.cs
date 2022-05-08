using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            string Lname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You are {0} {1}", name, Lname);
            Console.ReadKey();
        }
    }
}
