using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that traverses a collection of names and returns the first name, 
            whose sum of characters is equal to or larger than a given number N, which will be given on the first line. 
            Use a function that accepts another function as one of its parameters. 
            Start off by building a regular function to hold the basic logic of the program. 
            Something along the lines of Func<string, int, bool>. 
            Afterwards create your main function which should accept the first function as one of its parameters. */

            int num = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            
            string result = NameFunc(names,num);
            Console.WriteLine(result);
        }

        static string NameFunc(List<string> names, int num)
        {
            Func<string, int> GetSumAsciiCode = p =>
            {
                int sum = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    sum += p[i];
                };
                return sum;
            };

            foreach (var item in names)
            {
                if (GetSumAsciiCode(item) >= num)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
