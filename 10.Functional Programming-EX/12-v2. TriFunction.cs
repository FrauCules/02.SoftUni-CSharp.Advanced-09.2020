using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_v2._TriFunction
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
            Func<string, int> getAsciiSum = p =>
            {
                int sum = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    sum += p[i];
                };
                return sum;
            };
            Func<List<string>, int, Func<string, int>, string> nameResult = (names, num, getAsciiSum) => names.FirstOrDefault(p => getAsciiSum(p) >=num);
            
            Console.WriteLine(nameResult(names, num, getAsciiSum));
        }
    }
}
