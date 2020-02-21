using System;

namespace IntroToEvents
{
    class Program
    {
        public delegate void MyEventHandler(string s, int i, ConsoleColor color);
        public static event MyEventHandler PFEvent;
        public static int temperature;
        static void Main(string[] args)
        {
            Random random = new Random();
            int count = 0;
            PFEvent = new MyEventHandler(RaiseEvent);
            temperature = 70;

            while(true)
            {
                temperature += random.Next(-1, 2);
                if(temperature < 65 || temperature > 75)
                {
                    if (temperature < 65)
                        PFEvent("Temperature below threshold..warming up", 1);
                    else
                        PFEvent("Temperature above threshold..cooling down", -1);
                }
                Console.WriteLine($"Temperature {temperature}");
                //count++;
                System.Threading.Thread.Sleep(500);
            }

        }

        public static void RaiseEvent(string msg, int adjNumber)
        {
            temperature += adjNumber;
            Console.WriteLine(msg);
        }
    }
}
