using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public static class CarList
    {
        public static List<Car> cars = new List<Car>();

        public static void AddCar(Car c)
        {
            if (c.Year == 1900)
                throw new CarException("The year was not entered correctly");

            cars.Add(c);
        }
    }


}
