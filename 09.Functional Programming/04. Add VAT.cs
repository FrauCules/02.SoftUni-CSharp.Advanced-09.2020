using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads one line of double prices separated by ", ". Print the prices with added VAT for all of them. Format them to 2 signs after the decimal point. The order of the prices must be the same.
VAT is equal to 20% of the price.

            decimal[] numbers = Console.ReadLine().Split(", ").Select(decimal.Parse).Select(x => x * 1.2m).ToArray();
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
