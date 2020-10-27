using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            int wreath = 0;
            int flawerLeft = 0;

            while(lilies.Count>0 && roses.Count > 0)
            {
                int sum = lilies.Peek()+roses.Peek();
                while (sum > 15)
                {
                    sum -= 2;
                }
                if (sum == 15)
                {
                    wreath++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else
                {
                    flawerLeft += sum;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            int wreathAditional = flawerLeft / 15;
            wreath += wreathAditional;

            if (wreath >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!");
            }
            else 
            {
                Console.WriteLine($"You didn't make it, you need {5-wreath} wreaths more!");
            }
        }
    }
}
