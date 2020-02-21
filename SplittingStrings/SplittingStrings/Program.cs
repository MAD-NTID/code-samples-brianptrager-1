using System;
using System.IO;

namespace SplittingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("181.txt");

            string passage = sr.ReadToEnd();
            Console.ForegroundColor = ConsoleColor.Yellow;
            string[] lines = passage.Split("\n");
            Console.WriteLine($"There are {lines.Length} lines in this document\n");
            foreach(string s in lines)
            {
                Console.WriteLine(s);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            string[] dots = passage.Split(".");
            Console.WriteLine($"There are {dots.Length} values in the array.\n");
            foreach (string s in dots)
            {
                Console.WriteLine(s);
            }
            sr.Close();

            Console.ForegroundColor = ConsoleColor.Green;
            passage = passage.Replace("Rochester", "Massachusetts");
            passage = passage.Replace("RIT/NTID", "MIT");
            Console.WriteLine(passage);
            Console.ResetColor();
        }
    }
}
