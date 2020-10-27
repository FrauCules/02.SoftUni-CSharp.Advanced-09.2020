using System;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Print<int>(5);

            string text = Print("text");
        }

        static T Print<T>(T value) // след името на функцията има <T> -> Generic Function
        {
            //Console.WriteLine(typeof(T).GetType()); 
            
            Console.WriteLine(value);
            return value;
        }
    }
}
