﻿using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> name = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                name.Add(Console.ReadLine());
            }

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
