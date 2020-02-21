using System;

namespace Delegates
{
    class Program
    {
        public delegate void Print(int iValue);
        public delegate string Print2();
        static void Main(string[] args)
        {
            Print print1 = new Print(PrintNumber);

            print1(100);
            print1(200);
            print1(300);

            print1 += PrintMoney;
            print1(100);
            print1(200);
            print1(300);

            print1 -= PrintNumber;
            print1(100);
            print1(200);
            print1(300);

            Print2 secretString = SuperSecretFormula;
            Console.WriteLine(secretString());
        }

        public static void PrintNumber(int i)
        {
            Console.WriteLine($"Value: {i}");
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine($"Money {money:C}");
        }

        public static string SuperSecretFormula()
        {
            return "There is no secret formula, sorry to disappoint you.  Now go away!";
        }
    }
}
