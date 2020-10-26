using System;

namespace _99._Demo7___Constructors_чейнване
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Pesho", 15);
            Human noAlive = new Human();
            Console.WriteLine(noAlive.Name);
            Console.WriteLine(human.Name +" "+ human.Age);
            human.Eat();
            human.Eat();
            human.Die();
            human.Eat();
        }
    }
}
