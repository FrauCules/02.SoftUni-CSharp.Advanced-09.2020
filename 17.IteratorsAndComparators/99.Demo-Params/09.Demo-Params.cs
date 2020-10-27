using System;

namespace _09.Demo_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNames("Pesho", 5, 6, 7,8,9,0,1,2,3,4,5,6); // Params работи само с масив!!!!!
        }
        static void PrintNames(string name, params int[] names) // params ШРЯБВА да е единствения или последен подаван параметър
        {
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            Console.WriteLine(name);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
