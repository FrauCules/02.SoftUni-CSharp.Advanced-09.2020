using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        /* Write a program that reads one line of integers separated by ", ". Then prints the even numbers of that sequence sorted in increasing order.*/
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select((number) =>
                {
                    return int.Parse(number);
                })
                .Where(n => n % 2 == 0)
                .OrderBy((int x) => 
                {
                    return x;
                })
                .ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
