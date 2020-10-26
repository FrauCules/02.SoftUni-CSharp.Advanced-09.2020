using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] len = input.Split().Select(int.Parse).ToArray();
            HashSet<int> n = new HashSet<int>();
            HashSet<int> m = new HashSet<int>();
            HashSet<int> common = new HashSet<int>();

            for (int i = 0; i < len[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                n.Add(num);
            }

            for (int i = 0; i < len[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                m.Add(num);
            }

            foreach (var item in n)
            {
                if (m.Contains(item))
                {
                    common.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ",common));
        }
    }
}
