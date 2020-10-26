using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Queue<string> list = new Queue<string>();
            string line;
            int count = 0;

            while ((line = Console.ReadLine()) != "end")
            {
                if (line == "green")
                {
                    for (int i = 0; i < num; i++)
                    {
                        if (list.Count > 0)
                        {
                            Console.WriteLine($"{list.Dequeue()} passed!");
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    list.Enqueue(line);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
