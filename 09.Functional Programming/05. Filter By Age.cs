using System;

namespace _05._Filter_By_Age
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that receives an integer N on first line. On the next N lines, read pairs of "[name], [age]". Then read three lines with:
                •	Condition - "younger" or "older"
                •	Age - Integer
                •	Format - "name", "age" or "name age"
                Depending on the condition, print the correct pairs in the correct format. */

            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");
                people[i] = new Person() { Name = input[0], Age = int.Parse(input[1]) };
            }

            string condition = Console.ReadLine();
            int ageToFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> conditionDelegate = GetCondition(condition, ageToFilter);
            Action<Person> printerDelegate = GetPrinter(format);

            foreach (var item in people)
            {
                if (conditionDelegate(item))
                {
                    printerDelegate(item);
                }
            }
        }

        static Action<Person> GetPrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return p => { Console.WriteLine($"{p.Name}"); };
                case "age":
                    return p => { Console.WriteLine($"{p.Age}"); };
                case "name age":
                    return p => { Console.WriteLine($"{p.Name} - {p.Age}"); };
                default:
                    return null;
            }
        }

        static Func<Person,bool> GetCondition(string condition, int age)
        {
            switch(condition)
            {
                case "younger": return p => p.Age < age;
                case "older": return p => p.Age >= age;
                default:
                    return null;
            }
        }
    }
}
