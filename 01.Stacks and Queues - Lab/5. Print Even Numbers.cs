using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(line);
            Queue<int> result = new Queue<int>();
            int num=queue.Count;

            for (int i = 0; i < num; i++)
            {
                if (queue.Peek() % 2 == 0)
                {
                    result.Enqueue(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }
            }

            Console.WriteLine($"{string.Join(", ", result)}");
        }
    }
}
