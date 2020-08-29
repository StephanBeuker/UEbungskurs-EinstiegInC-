using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Übung3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hallo Jan, ich heiße {name}.");
            Console.WriteLine();
            Console.WriteLine("\t >>  Press Enter to Exit  <<");
            Console.ReadLine();
        }
    }
}
 