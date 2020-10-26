using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] list = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> order = new Queue<int>(list);
            
            Console.WriteLine(order.Max());

            if (order.Sum() <= food)
            {
                Console.WriteLine("Orders complete");
                return;
            }

            while (order.Count > 0)
            {
               if (food >= order.Peek())
                {
                    food -= order.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", order)}");
                    break;
                }
            }
        }
    }
}
