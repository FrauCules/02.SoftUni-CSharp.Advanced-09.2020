using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads a collection of names as strings from the console, 
            appends "Sir" in front of every name and prints it back on the console. 
            Use Action<T>.
            Input:
            Eathan Lucas Noah StanleyRoyce
             */

            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                Action<string> printWord = i => Console.WriteLine($"Sir {item}");
                printWord(item);
            }
        }
    }
}
