using System;
using System.Collections.Generic;

namespace Interfaces_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Car> cars = new List<Car>();
            List<IPurchasable> goods = new List<IPurchasable>();
            goods.Add(new Car { Make = "Ford", Model = "F-250", Year = 2017, Cost = 60000 });
            goods.Add(new Book { Title = "The Magician", Author = "Dumbledore", Genre = "Self-Help", Cost = 27 });
            goods.Add(new Car { Make = "Nissan", Model = "Sentra", Year = 2012, Cost = 25000 });
            goods.Add(new Book { Title = "Under The Dome", Author = "Stephen King", Genre = "Fiction", Cost = 17 });
            goods.Add(new Car { Make = "Chevrolet", Model = "Camaro SS", Year = 1969, Cost = 100000 });

            //List<Book> books = new List<Book>();
            goods.Add(new Book { Title = "The Catcher in the Rye", Author = "JD Salinger", Genre = "Fiction", Cost = 7 });
            
            

            foreach(IPurchasable good in goods)
            {
                if(good is Car)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(good.Purchase());
                }
                if(good is Book)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(good.Purchase());
                }
            }

            /*foreach(Car c in cars)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(c.Purchase());
            }

            foreach(Book b in books)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(b.Purchase());
            }*/

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
