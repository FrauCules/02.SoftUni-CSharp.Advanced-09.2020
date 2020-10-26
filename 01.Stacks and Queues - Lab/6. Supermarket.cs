using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> input = new Queue<string>();
            Queue<string> output = new Queue<string>();
            string line="";

            while ((line = Console.ReadLine()) != "End")
            {
                if (line != "Paid")
                {
                    input.Enqueue(line);
                }
                else
                {
                    int num = input.Count;
                    for (int i = 0; i < num; i++)
                    {
                        //Console.WriteLine(input.Peek());
                        output.Enqueue(input.Dequeue());
                    }
                    
                }
            }

            Console.WriteLine($"{string.Join("\n", output)}");
            Console.WriteLine($"{input.Count} people remaining.");
        }
    }
}
