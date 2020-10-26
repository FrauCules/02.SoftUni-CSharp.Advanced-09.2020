using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '(')
                {
                    stack.Push(i);
                    continue;
                }
                if(line[i] == ')')
                {
                    for (int j = stack.Pop(); j <= i; j++)
                    {
                        Console.Write(line[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
