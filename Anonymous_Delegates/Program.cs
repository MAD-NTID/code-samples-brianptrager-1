using System;

namespace Anonymous_Delegates
{
    class Program
    {
        delegate void MyDelAction();
        public delegate int AwesomeDelegate(ref int i, string s);
        static void Main(string[] args)
        {
            int newResult = 0;
            var newCar = new { Make = "Ford", Model = "F-150", Price = 54000M, Year = "2020", Color = "Blue" };
            //newCar.Sell();

            //dynamic brandNewCar = new { Make = "Nissan" };

            //brandNewCar.Sell();

            PrintInfo(newCar);

            MyDelAction del = delegate ()
            {
                Console.WriteLine("My super duper delegate!");
            };

           // del();

            del += delegate ()
            {
                Console.WriteLine("Shame on you Dylan!");
            };
            del();

            AwesomeDelegate f1 = Foo, f2 = Bar, f3 = Baz;
            AwesomeDelegate all = f1 + f2;
            all += f3;

            //int result = all(250, "Hello!");
            all -= f2;
            int result = all(ref newResult, "Goodbye!");

            Console.WriteLine(result);
        }

        public static void PrintInfo(dynamic val)
        {
            Console.WriteLine($"Make: {val.Make}");
            Console.WriteLine($"Model: {val.Model}");
            Console.WriteLine($"Price: {val.Price:C}");
            Console.WriteLine($"Year: {val.Year}");
            Console.WriteLine($"Color: {val.Color}");
        }

        public static int Foo(ref int i, string s)
        {
            return i += 100;

            //ignore the s, not important  -- No clue why I asked for it though
        }

        public static  int Bar(ref int i, string s)
        {
            return i += 200;

            //ignore the s, not important  -- No clue why I asked for it though
        }

        public static int Baz(ref int i, string s)
        {
            return i += 300;

            //ignore the s, not important  -- No clue why I asked for it though
        }

    }
}
