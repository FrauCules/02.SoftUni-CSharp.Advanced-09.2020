using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Dating_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> male = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                male.Push(input[i]);
            }

            Queue<int> female = new Queue<int>();
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                female.Enqueue(input[i]);
            }

            int matchesCount = 0;
            while (male.Count>0 && female.Count > 0)
            {
                if(male.Peek()<= 0)
                {
                    male.Pop();
                    continue;
                }
                if (female.Peek() <= 0)
                {
                    female.Dequeue();
                    continue;
                }

                if (male.Peek() % 25 == 0)
                {
                    male.Pop();
                    if (male.Count > 0)
                    {
                        male.Pop();
                    }
                    continue;
                }

                if (female.Peek() % 25 == 0)
                {
                    female.Dequeue();
                    if (female.Count > 0)
                    {
                        female.Dequeue();
                    }
                    continue;
                }

                if(male.Peek()== female.Peek())
                {
                    male.Pop();
                    female.Dequeue();
                    matchesCount++;
                    continue;
                }
                else
                {
                    female.Dequeue();
                    int num =male.Pop();
                    male.Push(num - 2);
                }

            }

            Console.WriteLine($"Matches: {matchesCount}");
            if (male.Count > 0)
            {
                Console.WriteLine($"Males left: {string.Join(", ", male)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (female.Count > 0)
            {
                Console.WriteLine($"Females left: {string.Join(", ", female)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
