using System;

namespace Lambdas
{
    class Program
    {
        public delegate double CalcDelegate(int x, double y);
        static void Main(string[] args)
        {
            //int x = 10;

            int a(int x) => x * 10;

            Console.WriteLine(a(5));

            //CalcDelegate calc = new CalcDelegate(CalcTaxAmount);
            CalcDelegate calc = (x, y) =>
            {
                return x * y;
            };
            
            Console.WriteLine($"{calc(50, 0.08):C}");

            // Action<int> Printer = new Action<int>(RandomPrint);
            // Printer(100);

            Action<int> Printer = i => Console.WriteLine(i);
            Printer(100);

            Func<int> exampleInt = () => new Random().Next();
            Printer(exampleInt());

            Func<int, bool> funkyInt = j => new Random().Next(j) >= 100;
            Console.WriteLine(funkyInt(500));
            


        }

        public static int a(int x)
        {
            return x * 10;
        }

        static void RandomPrint(int i)
        {
            Console.WriteLine(i);
        }
        //public static double CalcTaxAmount(int amt, double taxRate)
        //{
        //    return amt * taxRate;
        //}
    }
}
