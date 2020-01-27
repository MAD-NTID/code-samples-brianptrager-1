using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter a number between 1 and 10:");

            // Random rng = new Random();
            // int magicNumber = rng.Next(10);

            //// try
            //// {
            //     int guess = int.Parse(Console.ReadLine());
            //     if(guess == magicNumber)
            //         Console.WriteLine("Yep!");
            //     else
            //         Console.WriteLine("Wrong-o!!!");
            // //}
            // //catch(FormatException fe)
            // //{
            // //    Console.WriteLine(fe.Message);
            // //}
            //     Console.WriteLine("Muahahahahahaha!");

            CarList.cars.Add(new Car("Ford", "F-250", 2017));
            CarList.cars.Add(new Car("Ford", "F-250", 2017));
            CarList.cars.Add(new Car("Ford", "F-250", 2017));
            CarList.cars.Add(new Car("Ford", "F-250", 2017));
            CarList.cars.Add(new Car("Ford", "F-250", 2017));
            CarList.cars.Add(new Car("Ford", "F-250", 2017));
            CarList.cars.Add(new Car("Ford", "F-250", 2017));
            CarList.cars.Add(new Car("Ford", "F-250", 2017));

            try
            {
                CarList.AddCar(new Car());
            }
            catch(CarException ce)
            {
                Console.WriteLine(ce.Message);
            }

            int index = 1;
            foreach (Car c in CarList.cars)
            {
                Console.WriteLine($"{index} {c}");
                index++;
            }
            while (true)
            {
                Console.WriteLine($"Which car would you like? (1 - {CarList.cars.Count}):");
                int choice = int.Parse(Console.ReadLine());

                try
                {
                    Console.WriteLine(CarList.cars[--choice]);
                    Console.WriteLine("Congratulations!!!  You're not a buffoon after all, I mean on your new car!");
                    break;
                }
                catch (ArgumentOutOfRangeException aoore)
                {
                    Console.WriteLine("You old buffoon!  Read!!");
                    //Console.WriteLine(aoore.Message);
                }
            }
            //}

            //static void PrintList(IList<T> list)
            //{
            //    foreach(<T> t in list)
            //    {
            //        Console.WriteLine(t);
            //    }
            //}

        }
    }
}
