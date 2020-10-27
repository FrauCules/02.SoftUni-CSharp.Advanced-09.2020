using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Parking
{
    public class Parking
    {
        private List<Car> cars;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            this.cars = new List<Car>();
        }
        public string Type { get; set; }
        public int Capacity { get; set; }

        public int Count
            => this.cars.Count;

        public void Add(Car car)
        {
            if (cars.Count < Capacity)
            {
                cars.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            bool exist = cars.Any(x => x.Manufacturer == manufacturer && x.Model == model);
            if (exist)
            {
                cars = cars.Where(x => x.Manufacturer != manufacturer && x.Model != model).ToList();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Car GetLatestCar()
        {
            if (cars.Count == 0)
            {
                return null;
            }
            else
            {
                return cars.OrderByDescending(x=> x.Year).First();
            }
        }

        public Car GetCar(string manufacturer, string model)
        {
            bool exist = cars.Any(x => x.Manufacturer == manufacturer && x.Model == model);
            if (exist)
            {
                return cars.Where(x => x.Manufacturer == manufacturer && x.Model == model).First();
            }
            else
            {
                return null;
            }
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}:");
            foreach (var item in cars)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
