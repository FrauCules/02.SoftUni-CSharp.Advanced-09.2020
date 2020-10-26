using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ivancho’s parents are on a vacation for the holidays and he is planning an epic party at home. Unfortunately, his organizational skills are next to non-existent, so you are given the task to help him with the reservations.
                On the first line, you receive a list with all the people that are coming. On the next lines, until you get the "Party!" command, you may be asked to double or remove all the people that apply to a given criteria. There are three different criteria: 
                •	Everyone that has his name starting with a given string
                •	Everyone that has a name ending with a given string
                •	Everyone that has a name with a given length.
                Finally, print all the guests who are going to the party separated by ", " and then add the ending "are going to the party!". If there are no guests going to the party print "Nobody is going to the party!". See the examples below:
                */
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string line;
            HashSet<string> name = new HashSet<string>();
            List<string> names = new List<string>();

            while ((line = Console.ReadLine()) != "Party!")
            {
                string[] input = line.Split(" ").ToArray();
                string command = input[0];
                string filterTyp = input[1];
                string argument = input[2];

                if (command == "Double")
                {
                    switch (filterTyp)
                    {
                        case "StartsWith":
                            names = people.Where(x => x.StartsWith(argument)).ToList();
                            break;
                        case "EndsWith":
                            names = people.Where(x => x.EndsWith(argument)).ToList();
                            break;
                        case "Length":
                            names = people.Where(x => x.Length == int.Parse(argument)).ToList();
                            break;
                        default:
                            break;
                    }
                    for (int i = 0; i < names.Count; i++)
                    {
                        name.Add(names[i]);
                    }

                    for (int i = 0; i < people.Count; i++)
                    {
                        for (int j = 0; j < name.Count; j++)
                        {
                            if (name.Contains(people[i]))
                            {
                                people.Insert(i, people[i]);
                                i++;
                            }
                        }
                    }
                }
                
                if(command == "Remove")
                switch (filterTyp)
                {
                    case "StartsWith":
                        people = people.Where(x => !x.StartsWith(argument)).ToList();
                        break;
                    case "EndsWith":
                        people = people.Where(x => !x.EndsWith(argument)).ToList();
                        break;
                    case "Length":
                        people = people.Where(x => x.Length != int.Parse(argument)).ToList();
                        break;
                    default:
                        break;
                }
            }

            if (people.Count > 0)
            {
                Console.WriteLine(string.Join(", ", people) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
