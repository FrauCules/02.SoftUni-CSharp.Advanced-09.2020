using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            /* You are given a lower and an upper bound for a range of integer numbers. 
            Then a command specifies if you need to list all even or odd numbers in the given range. 
            Use Predicate<T>.
            
            Input 1: 
            1 10
            odd
            Output 1:
            1 3 5 7 9

            Input2:
            20 30
            even
            Output 2:
            20 22 24 26 28 30                    */

            int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int start = data[0];
            int end = data[1];
            string criteria = Console.ReadLine();

            Func<int, int, List<int>> listResult = (start, end) =>
             {
                 List<int> nums = new List<int>();

                 for (int i = start; i <= end; i++)
                 {
                     nums.Add(i);
                 }

                 return nums;
             };
            List<int> numbers = listResult(start, end);
            Predicate<int> criteriaPredicate = n => true;

            if (criteria == "odd")
            {
                criteriaPredicate = n => n % 2 != 0;
            }
            else
            {
                criteriaPredicate = n => n % 2 == 0;
            }
            
            numbers = MyWhere(numbers, criteriaPredicate);
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> MyWhere(List<int> items, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
