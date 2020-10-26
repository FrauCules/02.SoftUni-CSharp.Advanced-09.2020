using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                
                Tire[] tires = new Tire [4];
                int num = 0;
                for (int j = 5; j < input.Length; j+=2)
                {
                    double tirePressure = double.Parse(input[j]);
                    int tireAge = int.Parse(input[j+1]);

                    Tire tire = new Tire(tirePressure, tireAge);
                    tires[num++] = tire;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();  
            
            if(command == "fragile") // "fragile" - print all cars whose cargo is "fragile" with a tire, whose pressure is  < 1
            {
                var fragileCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(p => p.Pressure < 1)).ToList();
                foreach (var item in fragileCars)
                {
                    Console.WriteLine(item.Model);
                }
            }

            if (command == "flamable") // "flamable" - print all of the cars, whose cargo is "flamable" and have engine power > 250
            {
                var flamableCar = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power>250).ToList();
                foreach (var item in flamableCar)
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}
