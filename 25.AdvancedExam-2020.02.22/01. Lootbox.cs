using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> lotBox1 = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> lotBox2 = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int sum = 0;

            while(lotBox1.Count>0 && lotBox2.Count > 0)
            {
                if(lotBox1.Peek()==0 && lotBox2.Peek() == 0)
                {
                    if(lotBox1.Peek() == 0)
                    {
                        lotBox1.Dequeue();
                    }

                    if (lotBox2.Peek() == 0)
                    {
                        lotBox2.Pop();
                    }

                    continue;
                }

                if((lotBox1.Peek() + lotBox2.Peek()) % 2 != 0)
                {
                    lotBox1.Enqueue(lotBox2.Pop());
                }
                else
                {
                    sum += lotBox1.Peek() + lotBox2.Peek();
                    lotBox1.Dequeue();
                    lotBox2.Pop();
                }
            }

            if (lotBox1.Count <= 0)
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (lotBox2.Count <= 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
