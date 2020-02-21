using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_CSharp
{
    class Car : IPurchasable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Cost { get; set; }

        public Car()
        {
            this.Make = "Tucker";
            this.Model = "48";
            this.Year = 1948;
        }

        public string Purchase()
        {
            return $"You purchased {Year} {Make} {Model} for a price of {Cost:C}";
        }
    }
}
