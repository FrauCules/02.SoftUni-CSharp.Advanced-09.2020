using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(list);
            string line;

            while ((line = Console.ReadLine().ToLower()) != "end")
            {
                string[] input = line.Split().ToArray();
                string command = input[0];
                if (command == "add")
                {
                    stack.Push(int.Parse(input[1]));
                    stack.Push(int.Parse(input[2]));
                }
                else if (command == "remove")
                {
                    int len = int.Parse(input[1]);
                    if (len < stack.Count)
                    {
                        for (int i = 0; i < len; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            
            int sum = 0;
            sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
