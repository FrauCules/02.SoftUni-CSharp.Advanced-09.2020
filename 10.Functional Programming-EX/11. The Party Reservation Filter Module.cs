using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            List<string> filters = new List<string>();

            while ((command = Console.ReadLine()) != "Print")
            {
                string[] input = command.Split(";").ToArray();
                string filterTyp = input[1];
                string argument = input[2];

                if (command.StartsWith("Add"))
                {
                    filters.Add($"{filterTyp};{argument}");
                }
                else if (command.StartsWith("Remove"))
                {
                    filters.Remove($"{filterTyp};{argument}");
                }
            }

            foreach (var item in filters)
            {
                string[] tokens = item.Split(";");
                string filterTyp = tokens[0];
                string argument = tokens[1];

                switch (filterTyp)
                {
                    case "Starts with":
                        people = people.Where(x => !x.StartsWith(argument)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(x => !x.EndsWith(argument)).ToList();
                        break;
                    case "Length":
                        people = people.Where(x => x.Length !=int.Parse(argument)).ToList();
                        break;
                    case "Contains":
                        people = people.Where(x => !x.Contains(argument)).ToList();
                        break;
                    default:
                        break;
                }
            }

           Console.WriteLine(string.Join(" ", people));
        }
    }
}
