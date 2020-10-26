using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> list = new Queue<string>(input);
            int num = int.Parse(Console.ReadLine());
            string name;
            int count = 0;

            while (list.Count>1)
            {
                count++;
                if (count == num)
                {
                    Console.WriteLine($"Removed {list.Dequeue()}");
                    count = 0;
                }
                else
                {
                    list.Enqueue(list.Dequeue());
                }
            }

            Console.WriteLine($"Last is {list.Dequeue()}");
        }
    }
}
