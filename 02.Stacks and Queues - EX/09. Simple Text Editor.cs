using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string current = "";

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                if (input[0] == '1')
                {
                    stack.Push(current);
                    current = current + input.Substring(2);
                }

                if (input[0] == '2')
                {
                    stack.Push(current);
                    current = current.Remove(current.Length - int.Parse(input.Substring(2)));
                }

                if (input[0] == '3')
                {
                    int index = int.Parse(input.Substring(2));
                    Console.WriteLine(current[index-1]);
                }

                if (input[0] == '4')
                {
                    current = stack.Pop();
                }
            }
        }
    }
}
