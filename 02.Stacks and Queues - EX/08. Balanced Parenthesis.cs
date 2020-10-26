using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            Queue<char> second = new Queue<char>();
            string input = Console.ReadLine();
            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if(stack.Count< 1 && (input[i] == ')' || input[i] == ']' || input[i] == '}'))
                {
                    Console.WriteLine("NO");
                    return;
                }

                if (input[i] ==')'|| input[i] == ']'|| input[i] == '}')
                {
                    if((stack.Peek()=='('&& input[i] == ')')|| (stack.Peek() == '[' && input[i] == ']')|| (stack.Peek() == '{' && input[i] == '}'))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else
                {
                    stack.Push(input[i]);
                }
            }

            Console.WriteLine("YES");
        }
    }
}
