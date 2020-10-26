using System;

namespace _01._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads a collection of strings from the console and then prints them onto the console. 
            Each name should be printed on a new line. Use Action<T>.
            Inpiut: 
            Lucas Noah Tea
            */

            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                Action<string> printWord = i => Console.WriteLine(item);
                printWord(item);
            }
        }
    }
}
