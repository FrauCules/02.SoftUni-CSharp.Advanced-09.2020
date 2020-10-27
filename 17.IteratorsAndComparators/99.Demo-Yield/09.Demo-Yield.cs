using System;
using System.Collections;
using System.Collections.Generic;

namespace _09.Demo_Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (var name in GetNames())  // вариант 1
            //{
            //    Console.WriteLine(name);
            //    Console.WriteLine("печатам от foreach");
            //}

            var enumerator = GetNames().GetEnumerator();    // вариант 2
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public static IEnumerable<string> GetNames()
        { 
            yield return "Gosho";
            Console.WriteLine("Печатам от метода");
            yield return "Penka";
            Console.WriteLine("След Penka съм");
            yield return "Dima";
        }
    }
}
