using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            
            Lake lake = new Lake(stones); // или директно можем да подадем параметрите: Lake lake = new Lake(1,2,3,4)

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}