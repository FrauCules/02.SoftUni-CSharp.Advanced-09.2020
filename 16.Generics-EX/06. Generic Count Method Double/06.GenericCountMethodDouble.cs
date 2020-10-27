using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<double> values = new List<double>();

            for (int i = 0; i < num; i++)
            {
                double line = double.Parse(Console.ReadLine());
                values.Add(line);
            }

            double compare = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(values);

            int count = box.GetCountOfGreater(compare);
            Console.WriteLine(count);
        }
    }
}
