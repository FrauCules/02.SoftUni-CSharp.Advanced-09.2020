using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < line.Length; i++)
            {
                stack.Push(line[i]);
            }

            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
