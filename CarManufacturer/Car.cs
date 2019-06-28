using System;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            set => this.fuelQuantity = value;
        }
        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) 
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        public void Drive(double distance)
        {
            bool canContinue = this.FuelQuantity - (distance / 100 * this.FuelConsumption) >= 0;

            if (canContinue)
            {
                this.FuelQuantity -= distance * this.FuelConsumption / 100;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Make: {this.Make}");

            sb.AppendLine($"Model: {this.Model}");

            sb.AppendLine($"Year: {this.Year}");

            sb.Append($"Fuel: {this.FuelQuantity:F2}L");

            return sb.ToString();
        }
    }
}

