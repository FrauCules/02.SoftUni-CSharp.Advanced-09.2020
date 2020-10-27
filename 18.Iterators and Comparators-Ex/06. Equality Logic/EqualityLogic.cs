using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //List<Person> list = new List<Person>();
            SortedSet<Person> sort = new SortedSet<Person>(); // подредени уникални елементи, използвайки ЗАДЪЛЖИТЕЛНО IComparable
            HashSet<Person> hash = new HashSet<Person>();
            string line;

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                string[] input = line.Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                
                sort.Add(new Person(name, age));
                hash.Add(new Person(name, age));
            }

            Console.WriteLine(sort.Count);
            Console.WriteLine(hash.Count);
        }
    }
}
