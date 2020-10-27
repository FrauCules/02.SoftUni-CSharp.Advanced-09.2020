using System;
using System.Collections;
using System.Collections.Generic;

namespace _09.Demo_Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            //StringEnumerator enumerator = new StringEnumerator(array); // вар.1 итератор / на foreach
            //IEnumerator enumerator = array.GetEnumerator(); // вар.2 итератор / на foreach

            List<int> numbers = new List<int>() { 1, 2, 3 }; // вар.3 итератор / на foreach
            var enumerator = numbers.GetEnumerator();        // вар.3
            
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current); // печата елемента
            }
        }
    }
}
