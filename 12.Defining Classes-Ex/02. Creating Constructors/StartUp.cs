﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person();
            Person gosho = new Person(18);
            Person stamat = new Person(43, "Stamat");

            Console.WriteLine(pesho.Name + " -> " + pesho.Age);
            Console.WriteLine(gosho.Name + " -> " + gosho.Age);
            Console.WriteLine(stamat.Name + " -> " + stamat.Age);
        }
    }
}
