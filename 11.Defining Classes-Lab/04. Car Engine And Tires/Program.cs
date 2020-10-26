using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Engine engine = new Engine(650, 1000);
            Tire[] tires = new Tire[]
            {
                new Tire(2008, 1200),
                new Tire(2007, 1250),
                new Tire(2009, 1300),
                new Tire(2008, 1400),
            };
            Car firstCat = new Car();
            Car secondCat = new Car(make, model, year);
            Car thirdCat = new Car(make, model, year, fuelQuantity, fuelConsumption, engine,tires);
        }
    }
}
