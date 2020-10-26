using System;
using System.Collections.Generic;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
            string line;

            while ((line = Console.ReadLine()) != "Statistics")
            {
                string[] input = line.Split();
                if (input.Length == 4)
                {
                    if (!list.ContainsKey(input[0]))
                    {
                        list[input[0]] = new List<string>();
                    }

                }

                if(input.Length == 3)
                {
                    if (list.ContainsKey(input[0]))
                    {
                        if (input[0] != input[2])
                        {
                            if (!list[input[0]].Contains(input[2]))
                            {
                                list[input[0]].Add(input[2]);
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {list.Count} vloggers in its logs.");
            
            Console.WriteLine("Hello World!");
        }
    }
}
