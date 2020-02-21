using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO
{
    class Program
    {
        static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
            LoadData();
            Console.Clear();
            Menu();           
            
            //Console.WriteLine($"There are {cars.Count} cars in the list.");
            /*for(int i = 0; i < cars.Count; i++)
            {
                Car car = cars[i];
                Console.WriteLine($"##########Car #{i + 1}###################");
                Console.WriteLine($"Make: {car.GetMake()}\nModel: {car.GetModel()}\nYear: {car.GetYear().ToString()}\nColor: {car.GetColor()}\n");
            }*/
            

            //Save the information of cars to a file

           // cars.Clear();
            
        }//end Main

        private static string ReadString(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        private static int ReadInt(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());            
        }
        
        private static void SaveData()
        {
            StreamWriter writer = new StreamWriter("text.txt");
            foreach(Car ad in cars)
            {
                writer.WriteLine(ad.Make);
                writer.WriteLine(ad.Model);
                writer.WriteLine(ad.Year);
                writer.WriteLine(ad.Color);
            }
            writer.Close();
        }

        private static void LoadData()
        {
            
            try
            {
                if(File.Exists("text.txt"))  //Read if file exists
                {
                    StreamReader reader = new StreamReader("text.txt");
                    while(reader.EndOfStream != true)
                    {
                        string make = reader.ReadLine();
                        string model = reader.ReadLine();
                        int year = int.Parse(reader.ReadLine());
                        string color = reader.ReadLine();

                        cars.Add(new Car(make, model, year, color));

                        //cars.Add(new Car(reader.ReadLine(), reader.ReadLine(), int.Parse(reader.ReadLine()), reader.ReadLine());
                    }
                    reader.Close();
                }
                else
                    Console.WriteLine("File not found!");
            }
            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine("File Not Found: " + fnfe.Message);
            }
        }

        private static void CreateCar()
        {            
            while(true)
            {
                string make = ReadString("Enter make of car: ");
                //myCar.SetMake(Console.ReadLine());
 
                string model = ReadString("Enter model of car: ");
                //myCar.SetModel(Console.ReadLine());
                                
                int year = ReadInt("Enter year of car: ");
                //myCar.SetYear(int.Parse(Console.ReadLine()));
                  
                string color = ReadString("Enter color of car: ");
                //myCar.SetColor(Console.ReadLine());
                Car myCar = new Car(make, model, year, color);

                if(cars.Count != 0)
                {
                    Console.Write("Do you want to append this car to the beginning of the list? (y/n): ");
                    if(Console.ReadLine().ToUpper() == "Y")
                        cars.Insert(0, myCar);
                    else
                        cars.Add(myCar);
                }
                else
                    cars.Add(myCar);

                Console.Write("Do you wish to create another car? (y/n): ");

                //Array.Resize(ref cars, cars.Length + 1);
                //cars[cars.Length - 1] = myCar;

                if(!(Console.ReadLine().ToUpper()[0] == 'Y'))   
                    break;
            }
        }

        private static void DisplayCars()
        {
            Console.WriteLine($"There are {cars.Count} cars in the list.");
            int i = 0;
            foreach(Car c in cars)
            {
                Console.WriteLine($"##########Car #{i + 1}###################");
                Console.WriteLine(c.ToString());
                i++;
            }
        }

        private static void DeleteCars()
        {
            Console.Write("Which car would you like to delete? ");
            int carDelete = int.Parse(Console.ReadLine());
            int i = 0;
            foreach(Car c in cars)
            {
                Console.WriteLine($"##########Car #{i + 1}###################");
                Console.WriteLine(c.ToString());
                i++;
            }
            cars.RemoveAt(carDelete);
        }

        private static void ExitProgram()
        {
            Console.Write("Are you sure you want to exit the program? (Y/N): ");
            if(Console.ReadLine().ToUpper() == "Y")
            {
                SaveData();
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if(Console.ReadLine().ToUpper() == "N")
            {
                Menu();
            }
        }

        private static void Menu()
        {
            while (true)
            {
                Console.Write("1. Create a car\n2. Show List of Cars\n3. Delete a Car\n4. Exit Program\nPlease enter your selection: ");
                int menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        CreateCar();
                        break;
                    case 2:
                        DisplayCars();
                        break;
                    case 3:
                        DeleteCars();
                        break;
                    case 4:
                        ExitProgram();
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
            }
        }

       
    }
}
