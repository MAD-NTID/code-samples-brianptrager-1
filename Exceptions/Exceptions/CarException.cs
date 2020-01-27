using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class CarException : Exception
    {
        public CarException() : base("Car was not defined fully")
        {
            Console.WriteLine("CarException() invoked");
        }

        public CarException(string message) : base(message)
        {
            Console.WriteLine("CarException(string message) invoked");
        }


    }
}
