using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,int>> list= new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            string color;
            string clothes;

            for (int i = 0; i < n; i++)
            {
                string[] separator = { " -> ", "," };
                string[] input=Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

                color = input[0];
                if (!list.ContainsKey(color))
                {
                    list[color] = new Dictionary<string, int>();
                } 
                
                for (int j = 1; j < input.Length; j++)
                {
                    if (!list[color].ContainsKey(input[j]))
                    {
                        list[input[0]][input[j]] = 1;
                    }
                    else
                    {
                        list[input[0]][input[j]]++;
                    }
                }
            }

            string[] putOn = Console.ReadLine().Split();
            color = putOn[0];
            clothes = putOn[1];

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var items in item.Value)
                {
                    if (color == item.Key && clothes== items.Key)
                    {
                        Console.WriteLine($"* {items.Key} - {items.Value} (found!)");

                    }
                    else
                    {
                        Console.WriteLine($"* {items.Key} - {items.Value}");

                    }
                }
            }     
        }
    }
}
