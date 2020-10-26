using System;
using System.Collections.Generic;
using System.Text;

namespace _99._Demo5___Dogs
{
    class Dog
    {
        private int bitenPeopleCount;
        private string firstName;
        private string lastName;

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
    }
}
