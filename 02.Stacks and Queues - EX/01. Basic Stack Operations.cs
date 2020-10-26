using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = list1[0];
            int s = list1[1];
            int x = list1[2];
            int[] list= Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            
            if (n > list.Length)
            {
                n = list.Length;
            }

            for (int i = 0; i < n; i++)
            {
                stack.Push(list[i]);
            }

            if (s > list.Length)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
                return;
            }
            else if (stack.Count>0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
