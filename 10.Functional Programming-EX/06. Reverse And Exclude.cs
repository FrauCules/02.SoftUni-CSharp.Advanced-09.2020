using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reverses a collection and removes elements that are divisible by a given integer n. Use predicates/functions.*/
            List<int> nums = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            nums.Reverse();
            Func<int, bool> predicate = x => x % n != 0;
            nums = nums.Where(predicate).ToList();
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
