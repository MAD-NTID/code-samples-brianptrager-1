using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car()
        {
            this.Make = "N/A";
            this.Model = "N/A";
            this.Year = 1900;
        }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public override string ToString()
        {
            return String.Format($"Make: {Make}\nModel: {Model}\nYear: {Year}\n==============================");
        }
    }
}
