using System;
using System.Collections.Generic;
using System.Text;

namespace _99._Demo6___Inicialization
{
    class Dog
    {
        private int bitenPeopleCount;
        private string firstName;
        private string lastName;
        private int age;

        public bool IsBadDog { get
            {
                return bitenPeopleCount >= 2;
            } 
        }
        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
            set
            {
                var split = value.Split(" ");
                firstName = split[0];
                lastName = split[1];
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Невалидни години");
                }
                if (value > 100)
                {
                    throw new ArgumentException("Нереално големи години");
                }

                age = value;
            }
        }

        public void BitePerson()
        {
            bitenPeopleCount++;
        }
    }
}
