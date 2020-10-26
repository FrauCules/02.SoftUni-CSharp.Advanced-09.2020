using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a custom comparator that sorts all even numbers before all the odd ones in ascending order. 
             * Pass it to Array.Sort() function and print the result. Use functions */

            int[] nums = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Array.Sort(nums, (x, y) =>
            {
                int sorter = 0;
                if (x % 2 ==0 && y % 2 != 0) // ако първото число е четно, а второто нечетно - остват си така
                {
                    sorter = -1;
                }
                else if (x % 2 != 0 && y % 2 == 0) // ако първото число е нечетно, а второто четно - ще се разменят
                {
                    sorter = 1;
                }
                else // ако и двете числа са четни или нечетни - ги подрежда по големина
                {
                    //sorter = x - y;             // Вариант на сравнение 1
                    sorter = x.CompareTo(y);    // Вариант на сравнение 2
                }

                return sorter;
            });

            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
