using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>(); 
        }
        public List<Person> People { get; set; }
        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            //// Вариант 1
            int maxAge = int.MinValue;
            Person oldestMember = null;
            foreach (var item in People)
            {
                var currentAge = item.Age;
                if (currentAge > maxAge)
                {
                    maxAge = currentAge;
                    oldestMember = item;
                }
            }
            return oldestMember;

            //Вариант 2
            //Person oldestMember = People.OrderByDescending(x => x.Age).ToArray().First(); // 2.1

            //Person oldestMember = People.OrderByDescending(x => x.Age).ToArray()[0];      // 2.2
            //return oldestMember;

            //return People.OrderByDescending(x => x.Age).ToArray()[0];


            // Вариант 3 
            /*
            public Person GetOldestMember()
                => return People.OrderByDescending(x => x.Age).ToArray()[0];
            */
        }
    }
}
