using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> values = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string line = Console.ReadLine();
                values.Add(line);
            }

            int[] index = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int first = index[0];
            int second = index[1];

            Box<string> box = new Box<string>(values);

            box.Swap(first, second);

            foreach (var item in values)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
