using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> list = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                if (!list.ContainsKey(digit))
                {
                    list[digit] = 1;
                }
                else
                {
                    list[digit]++;
                }
            }

            foreach (var item in list)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    return;
                }
            }
        }
    }
}
