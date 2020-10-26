using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> list = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!list.ContainsKey(name))
                {
                    list.Add(name, new List<decimal>());
                }
                    
                list[name].Add(grade);
            }

            foreach (var item in list)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var items in item.Value)
                {
                    Console.Write($"{items:f2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
        }
    }
}
