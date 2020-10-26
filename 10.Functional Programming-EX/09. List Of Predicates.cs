using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Find all numbers in the range 1...N that are divisible by the numbers of a given sequence. 
            On the first line, you will be given an integer N – which is the end of the range. 
            On the second line, you will be given a sequence of integers which are the dividers. Use predicates/functions.
            */
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> resultArray = new List<int>();
            Func<int, int, bool> devide = (x, y) => x % y == 0;

            for (int i = 1; i <= n; i++)
            {
                bool result = true;
                for (int z = 0; z < nums.Length; z++)
                {
                    if (!devide(i, nums[z]))
                    {
                        result = false;
                        break;
                    }
                }
                if (result)
                {
                    resultArray.Add(i);
                }
            }
            
            Console.WriteLine(string.Join(" ",resultArray));
        }
    }
}
