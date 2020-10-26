using System;
using System.Linq;

namespace _02._Sum_Numbers___Func // Разновидности на синтаксиса на Func
{
    class Program
    {
        /* Write a program that reads a line of integers separated by ", ". Print on two lines the count of numbers and their sum.*/
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(ParseNumber).ToArray();

            PrintResults(array, GetCount, Sum);                     // Вариант 1     
            PrintResults(array, GetCount, x=> { return x.Sum(); }); // Вариант 2
            PrintResults(array, GetCount, x =>                      // Вариант 3 
            {
                int sum = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    sum = +x[i];
                }
                return sum;
            });
        }

        static void PrintResults(int[] array, Func<int[], int> count, Func<int[], int> sum)
        {
            Console.WriteLine(count(array));
            Console.WriteLine(sum(array));
        }

        static int GetCount(int[] array)
        {
            return array.Length;
        }

        static int Sum(int[] array)
        {
            return array.Sum();
        }


        static int ParseNumber(string number)
        {
            return int.Parse(number);
        }

    }

}

