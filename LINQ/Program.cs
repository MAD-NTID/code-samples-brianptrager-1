using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classRoster = { "John Doe", "Jane Doe", "Mama Joe", "Papa Joe", "Jo Joestar" };

            //Get names that start with J
            //var uClassRoster = from c in classRoster
            //                   where c.StartsWith("J")
            //                   select c;

            //foreach(string s in uClassRoster)
            //{
            //    Console.WriteLine(s);
            //}
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(var student in classRoster.Where(s => s.StartsWith("M")))
                Console.WriteLine(student);

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var student in classRoster.Where(s => s.Length >= 10))
                Console.WriteLine(student);

            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach(string student in classRoster.OrderBy(s => s))
                Console.WriteLine(student);

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach(string student in classRoster.Where(s => s == "Jo Joestar"))
                Console.WriteLine(student);  

        }
    }
}
