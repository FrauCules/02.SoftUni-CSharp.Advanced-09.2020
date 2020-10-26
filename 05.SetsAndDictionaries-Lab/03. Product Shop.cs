using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,double>> list = new Dictionary<string, Dictionary<string, double>>();
            var input=""; 

            while((input=Console.ReadLine())!="Revision")
            {
                string[] data = input.Split(", ");
                string name = data[0];
                string product = data[1];
                double price = double.Parse(data[2]);

                if (!list.ContainsKey(name))
                {
                    list[name] = new Dictionary<string, double>();
                }

                if (!list[name].ContainsKey(product))
                {
                    list[name][product] = price;
                }
            }

            foreach (var item in list.OrderBy(x=> x.Key).ToDictionary(x=>x.Key, x=>x.Value))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var items in item.Value)
                {
                    Console.WriteLine($"Product: {items.Key}, Price: {items.Value}");
                }
            }
        }
    }
}
