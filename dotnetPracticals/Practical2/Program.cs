using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, country;

            Console.WriteLine("Hello,Enter your Name:");
            name = Console.ReadLine();

            Console.WriteLine("Where are you from :");
            country = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Hi " + name + " from country " + country);
        }
    }
}
