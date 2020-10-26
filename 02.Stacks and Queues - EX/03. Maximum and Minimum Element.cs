using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            Stack<byte> list = new Stack<byte>();
            byte[] input = new byte[2];

            for (byte i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(byte.Parse).ToArray();

                switch (input[0])
                {
                    case 1:
                        list.Push(input[1]);
                        break;
                    case 2:
                        if (list.Count > 0)
                        {
                            list.Pop();
                        }
                        break;
                    case 3:
                        if (list.Count > 0)
                        {
                            Console.WriteLine(list.Max());
                        }
                        break;
                    case 4:
                        if (list.Count > 0)
                        {
                            Console.WriteLine(list.Min());
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{string.Join(", ", list)}");
        }
    }
}
