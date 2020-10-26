using System;

namespace _99._Demo7___Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Pesho");
            Human noAlive = new Human();
            Console.WriteLine(noAlive.Name);
            Console.WriteLine(human.Name);
            human.Eat();
            human.Eat();
            human.Die();
            human.Eat();
        }    
    }
}
