using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class Program
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

            string compare = Console.ReadLine();

            Box<string> box = new Box<string>(values);

            int count = box.GetCountOfGreater(compare);
            Console.WriteLine(count);

        }
    }
}
