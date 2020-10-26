using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = list1[0];
            int s = list1[1];
            int x = list1[2];
            int[] list = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            
            if (n > list.Length)
            {
                n = list.Length;
            }

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(list[i]);
            }

            if (s > list.Length)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
