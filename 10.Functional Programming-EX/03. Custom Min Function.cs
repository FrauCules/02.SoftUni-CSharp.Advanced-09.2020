using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a simple program that reads from the console a set of integers and prints back on the console the smallest number from the collection. Use Func<T, T>.*/
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> minFunc = nums => 
            {
                int minNum = Int32.MaxValue;
                foreach (var item in nums)
                {
                    if (minNum > item)
                    {
                        minNum = item;
                    }
                }

                return minNum;
            };
            Console.WriteLine(minFunc(numbers));
            
        }

        //static int GetMin(int[] nums) // Вариант 2 - Явна функция == на анонимната Func
        //{
        //    int minNum = Int32.MaxValue;
        //    foreach (var item in nums)
        //    {
        //        if (minNum > item)
        //        {
        //            minNum = item;
        //        }
        //    }

        //    return minNum;
        //}
    }
}
