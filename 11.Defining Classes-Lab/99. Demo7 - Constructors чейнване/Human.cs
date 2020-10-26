using System;
using System.Collections.Generic;
using System.Text;

namespace _99._Demo7___Constructors_чейнване
{
    class Human
    {
        private bool isAlive;
        public Human()
        {
            isAlive = true;
        }
        public Human(string name): this()
        {
            Name = name;
        }
        public Human(string name, int age): this (name)
        {
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
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
