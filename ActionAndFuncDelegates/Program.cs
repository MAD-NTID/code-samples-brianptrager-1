using System;

namespace ActionAndFuncDelegates
{
    class Program
    {
        //delegate void MyDelegate(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //MyDelegate myDel = new MyDelegate(Add);
            Action<int, int> myDel = Add;
            myDel(3,4);

            Func<int, int, int> myAddBuddy = AddReturn;
            myAddBuddy += SubtractReturn;
            myAddBuddy += MultiplyReturn;
            Console.WriteLine($"My Add Buddy says: {myAddBuddy(5, 6)}");

            
            Action<int> awesomeTask = delegate (int x)
            {
                Random random = new Random();
                Console.WriteLine($"The magic number is {random.Next(x)}!!");
            };
            awesomeTask(100);

            Func<double> superAwesomeTask = delegate ()
            {
                return Math.PI;
            };
            Console.WriteLine($"Result of Super Awesome Task: {superAwesomeTask()}");
        }

        public static void Add(int x, int y)
        {
            Console.WriteLine($"Add total: {x + y}");
        }

        public static int AddReturn(int x, int y)
        {
            return x + y;
        }

        public static int SubtractReturn(int x, int y)
        {
            return x - y;
        }

        public static int MultiplyReturn(int x, int y)
        {
            return x * y;
        }
    }
}
