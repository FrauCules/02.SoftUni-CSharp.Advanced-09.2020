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

            Car firstCat=new Car();
            Car secondCat = new Car(make, model, year);
            Car thirdCat = new Car(make, model, year,fuelQuantity, fuelConsumption);
            
        }
    }
}
