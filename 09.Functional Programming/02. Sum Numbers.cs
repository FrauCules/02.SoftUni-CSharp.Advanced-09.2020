﻿using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        /* Write a program that reads a line of integers separated by ", ". Print on two lines the count of numbers and their sum.*/
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}
