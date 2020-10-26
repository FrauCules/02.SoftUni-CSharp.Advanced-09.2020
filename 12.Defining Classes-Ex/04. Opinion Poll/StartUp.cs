using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = line[0];
                int age = int.Parse(line[1]);

                Person person = new Person(age, name);

                family.AddMember(person);
            }

            Person[] resultArray = family.GetPeople();

            foreach (var item in resultArray)
            {
                Console.WriteLine(item.Name + " - " + item.Age);
            }
        }
    }
}
