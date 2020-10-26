using System;
using System.Linq;

namespace _08_v2._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a custom comparator that sorts all even numbers before all the odd ones in ascending order. 
             * Pass it to Array.Sort() function and print the result. Use functions 
             Решение с тернарен оператор*/

            int[] nums = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Array.Sort(nums, (x, y) =>
                (x % 2 == 0 && y % 2 != 0) ? -1 :       // ако първото число е четно, а второто нечетно - остват си така
                (x % 2 != 0 && y % 2 == 0) ? 1 :        // ако първото число е нечетно, а второто четно - ще се разменят
                x.CompareTo(y));                        // ако и двете са четни или нечетни ги подрежда по големина
                
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
