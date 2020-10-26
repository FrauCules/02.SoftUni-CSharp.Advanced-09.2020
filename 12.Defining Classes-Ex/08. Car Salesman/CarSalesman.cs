using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string engineModel = input[0];
                int power = int.Parse(input[1]);
                string displacement = "n/a";
                string efficiency = "n/a";

                if (input.Length == 3)
                {
                    if (Char.IsDigit(input[2][0]))
                    {
                        displacement = input[2];
                    }
                    else
                    {
                        efficiency = input[2];
                    }
                }

                if (input.Length == 4)
                {
                    displacement = input[2];
                    efficiency = input[3];
                }
                Engine engine = new Engine(engineModel, power, displacement, efficiency);
                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                /* •	Model
                    •	Engine
                    •	Weight 
                    •	Color
                    */
                string model = input[0];
                string engine = input[1];
                string weight = "n/a";
                string color = "n/a";

                if (input.Length == 3)
                {
                    if (Char.IsDigit(input[2][0]))
                    {
                        weight = input[2];
                    }
                    else
                    {
                        color = input[2];
                    }
                }

                if (input.Length == 4)
                {
                    weight = input[2];
                    color = input[3];
                }
                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }


            foreach (var item in cars)
            {
                item.ToString();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.EngineModel}:");
                Engine engine = engines.FirstOrDefault(x => x.Model == car.EngineModel);
                Console.WriteLine($"    Power: {engine.Power}");
                Console.WriteLine($"    Displacement: {engine.Displacement}");
                Console.WriteLine($"    Efficiency: {engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
