using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            string line;

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                string[] input = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                
                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            while((line = Console.ReadLine()) != "End")
            {
                string[] input = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[1];
                int amount = int.Parse(input[2]);

                //Car[] car = cars.Where(x => x.Model == model).ToArray(); // когато търсим колекция от инстанции по условие
                //Car car = GetCar(cars, model); // Вариант2

                Car car = cars.FirstOrDefault(x => x.Model == model); // Вариант 1

                car.Drive(amount);
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }

        //private static Car GetCar(List<Car> cars, string model) // идентичен с Вариант 1
        //{
        //    foreach (var item in cars)
        //    {
        //        if(item.Model == model)
        //        {
        //            return item;
        //        }
        //    }
        //    return null;
        //}
    }
} 
