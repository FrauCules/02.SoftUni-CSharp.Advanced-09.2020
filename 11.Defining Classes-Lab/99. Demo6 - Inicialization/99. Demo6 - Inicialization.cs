using System;

namespace _99._Demo6___Inicialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.FullName = "Dog Dogov";

            Console.WriteLine(dog.FullName);
            dog.Age = 55;
            dog.BitePerson();
            dog.BitePerson();
            Console.WriteLine(dog.IsBadDog);
        }
    }
}
