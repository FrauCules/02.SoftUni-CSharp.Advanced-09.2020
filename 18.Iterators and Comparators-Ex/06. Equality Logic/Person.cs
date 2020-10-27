using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        
        public int CompareTo(Person other) // връща число: -1 - първото е <; 0-равни са; 1- второто е по-голямо
                                           // Този метод се ползва от SortedSet, за да изкл.повтарящи се записи 
        {
            if (Name.CompareTo(other.Name) != 0)
            {
                return Name.CompareTo(other.Name);
            }

            if (Age.CompareTo(other.Age) != 0)
            {
                return Age.CompareTo(other.Age);
            }

            return 0;
        }

        public override int GetHashCode() // връща GetHashCode на всяка отделна инстанция
        {
            return Name.GetHashCode() + Age.GetHashCode();
        }

        public override bool Equals(object? obj) // как да сравнява по GetHashCode
        {
            if (GetHashCode() == obj.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }
        }    
    }
}
