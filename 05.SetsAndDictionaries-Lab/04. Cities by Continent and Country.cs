using System;
using System.Collections.Generic;
using System.Linq;


namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> list = new Dictionary<string, Dictionary<string, List<string>>>();
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string[] data = Console.ReadLine().Split(" ");
                string continents = data[0];
                string contries = data[1];
                string cities = data[2];

                if (!list.ContainsKey(continents))
                {
                    list[continents] = new Dictionary<string, List<string>>();
                }

                if (!list[continents].ContainsKey(contries))
                {
                    
                    list[continents][contries] =new List<string>();
                }
                list[continents][contries].Add(cities);
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var items in item.Value)
                {
                    var towns = items.Key.ToList();
                    Console.WriteLine($"  {items.Key} -> {string.Join(", ", items.Value)}");

                }
            }
        }
    }
}
