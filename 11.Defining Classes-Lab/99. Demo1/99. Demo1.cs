using System;

namespace _99._Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sharoDog = new Dog();
            sharoDog.Name = "Sharo";
            sharoDog.Years = 7;
            Console.WriteLine(sharoDog.Name + " "+ sharoDog.Years);

            Dog peshoDog = new Dog();
            peshoDog.Name = "Pesho";
            Console.WriteLine(peshoDog.Name + " " + peshoDog.Years);
        }
    }
}
