using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] list = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> times = new Dictionary<double, int>();

            for (int i = 0; i < list.Length; i++)
            {
                if (!times.ContainsKey(list[i]))
                {
                    times.Add(list[i],1);
                }
                else
                {
                    times[list[i]]++;
                }
            }

            foreach (var item in times)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
