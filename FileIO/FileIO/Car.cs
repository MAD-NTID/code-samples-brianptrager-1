using System;

namespace FileIO
{
    public class Car
    {
        //Class variables
       // public string make;
        //private string model;
        //private int year;
       // private string color;

        private string make;

	    public string Make
	    {
		    get { return make;}
		    set
            {
                if(value == "Ford" || value == "Nissan" || value == "Rolls Royce" || value == "Audi" || value == "Toyota")
                {
                     make = value;
                }
                else
                {
                    make = "N/A";
                }
            }
	    }

        private string model;

	    public string Model
	    {
		    get { return model;}
		    set { model = value;}
	    }
        private int year;

	    public int Year
	    {
		    get { return year;}
		    set
            {
                if(value > 1900)
                {
                     year = value;
                }
                else
                {
                    year = DateTime.Now.Year;
                }
            }
	    }

        private string color;

	    public string Color
	    {
		    get { return color;}
		    set { color = value;}
	    }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Car()
        {
            this.Make = "Rolls Royce";
            this.Model = "Phantom";
            this.Year = DateTime.Now.Year;
            this.Color = "Red";
        }

        /// <summary>
        /// Parameterized constructor (constructor with parameters)
        /// </summary>
        /// <param name="make">Make of car</param>
        /// <param name="model">Model of car</param>
        /// <param name="year">Year of car</param>
        /// <param name="color">Color of car</param>
        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        /// <summary>
        /// Validates data (make) and sets value if valid
        /// </summary>
        /// <param name="_make">Make of car</param>
        //public void SetMake(string _make)
        //{
            
        //}

        /// <summary>
        /// Sets model of car (no validation)
        /// </summary>
        /// <param name="model">Model of car</param>
        //public void SetModel(string model)
        //{
            //this.model = model;
        //}

        /// <summary>
        /// Validates data (year) and sets value if data is 1900 or newer
        /// </summary>
        /// <param name="year">year of car</param>
        //public void SetYear(int year)
        //{
            //if(year > 1900)
                //this.year = year;
            //else
                //this.year = DateTime.Now.Year;
        //}

        /// <summary>
        /// Sets value to color
        /// </summary>
        /// <param name="color">Color of car</param>
        //public void SetColor(string color)
        //{
            //this.color = color;
        //}

        /// <summary>
        /// Returns make of car
        /// </summary>
        /// <returns>make</returns>
        //public string GetMake()
        //{
            //return this.make;
        //}

        /// <summary>
        /// Returns model of car
        /// </summary>
        /// <returns>model</returns>
        //public string GetModel()
        //{
            //return this.model;
        //}
        
        /// <summary>
        /// Returns year of car
        /// </summary>
        /// <returns>year</returns>
        //public int GetYear()
        //{
            //return this.year;
        //}

        /// <summary>
        /// Returns color of car
        /// </summary>
        /// <returns>color</returns>
        //public string GetColor()
        //{
            //return this.color;
       // }

        public override string ToString()
        {
            return String.Format($"Make: {Make}\nModel: {Model}\nYear: {Year.ToString()}\nColor: {Color}\n");
        }
    }
}