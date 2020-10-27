using System;
using System.Collections.Generic;

namespace _05._Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            string line;

            while ((line = Console.ReadLine()) != "END")
            {
                string[] input = line.Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];

                list.Add(new Person(name, age, town));
            }

            int index = int.Parse(Console.ReadLine());

            Person person = list[index - 1];

            int sum = 0;
            foreach (var item in list)
            {
                if (person.CompareTo(item) == 0)
                {
                    sum++;
                }
            }

            if (sum > 1)
            {
                Console.WriteLine($"{sum} {list.Count-sum} {list.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
