using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        string make;
        string model;
        int year;
        double fuelQuantity;
        double fuelConsumption;
        public string Make {
            get { return make; }
            set { this.make = value;}}
        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return year; }
            set { this.year = value; }
        }
        public double FuelQuantity {
            get { return fuelQuantity; }
            set { this.fuelQuantity = value; }}
        public double FuelConsumption {
            get { return fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            bool canContinue = this.FuelQuantity - distance * this.FuelConsumption >= 0;

            if (canContinue)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
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
