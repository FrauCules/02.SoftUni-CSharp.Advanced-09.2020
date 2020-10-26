using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> list = new Dictionary<char, int>();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (!list.ContainsKey(ch))
                {
                    list[ch] = 1;
                }
                else
                {
                    list[ch]++;
                }
            }

            foreach (var item in list.OrderBy(s=>s.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
