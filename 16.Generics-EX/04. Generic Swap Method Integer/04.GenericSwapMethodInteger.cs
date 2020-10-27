using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<int> values = new List<int>();

            for (int i = 0; i < num; i++)
            {
                int line = int.Parse(Console.ReadLine());
                values.Add(line);
            }

            int[] index = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int first = index[0];
            int second = index[1];

            Box<int> box = new Box<int>(values);

            box.Swap(first, second);

            foreach (var item in values)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
