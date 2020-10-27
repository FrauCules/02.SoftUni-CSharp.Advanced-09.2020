using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var result1 = new EqualityScale<int>(4, 5);
            Console.WriteLine(result1.AreEquals());

            var result2 = new EqualityScale<string>("sun", "sun");
            Console.WriteLine(result2.AreEquals());
        }
    }
}
