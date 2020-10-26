using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> list = new Queue<string>(input);
           
            var command = Console.ReadLine();
            while (list.Count>0)
            {
                if (command == "Play")
                {
                    list.Dequeue();
                }

                else if (command.Contains("Add"))
                {
                    var song = command.Split("Add ",StringSplitOptions.RemoveEmptyEntries);

                    if (list.Contains(song[0]))
                    {
                        Console.WriteLine($"{song[0]} is already contained!");
                    }
                    else
                    {
                        list.Enqueue(song[0]);
                    }
                }
                else if(command == "Show")
                {
                    Console.WriteLine(string.Join(", ", list));
                }
                
                command = Console.ReadLine();
            } 
            
            Console.WriteLine("No more songs!");
        }
    }
}
