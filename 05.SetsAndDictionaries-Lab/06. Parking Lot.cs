using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> car = new HashSet<string>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] data = input.Split(", ");
                if (data[0] == "IN")
                {
                    car.Add(data[1]);
                }

                if (data[0] == "OUT")
                {
                    if (car.Contains(data[1]))
                    {
                        car.Remove(data[1]);
                    }
                }
            }

            if (car.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in car)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
