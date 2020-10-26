using System;
using System.Collections.Generic;
using System.Text;

namespace _99._Demo7___Constructors
{
    class Human
    {
        private bool isAlive;
        public Human()
        {
            isAlive = false;
            Name = "NoName";
        }
        public Human(string name)
        {
            isAlive = true;
            Name = name;
        } 
        public string Name { get; set; }
        public void Eat()
        {
            if (isAlive)
            {
                Console.WriteLine("I am aeting");
            }
        }
        public void Die()
        {
            isAlive = false;
        }
    }
}
