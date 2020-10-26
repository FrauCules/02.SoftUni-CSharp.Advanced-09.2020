using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> stack = new Stack<string>(line);

            while (stack.Count > 1)
            {
                int operand1 = int.Parse(stack.Pop());
                string opetator = stack.Pop();
                int operand2 = int.Parse(stack.Pop());
                int result = 0;

                switch (opetator)
                {
                    case "+":
                        result = operand1+operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        result = operand1 / operand2;
                        break;
                }
                
                stack.Push(result.ToString());
            }

            
            Console.WriteLine(stack.Peek());
        }
    }
}
