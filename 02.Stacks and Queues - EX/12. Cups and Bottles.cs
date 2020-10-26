using System;
using System.Linq;
using System.Collections.Generic;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> cups = new Queue<int>(list);
            list = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bottles = new Stack<int>(list);
            int currentCup = 0;
            int currentBottle = 0;
            int wastedWater = 0;
            currentBottle = bottles.Pop();

            while (true)
            {
                if (currentCup <= 0)
                {
                    if (cups.Count > 0 && currentBottle > 0)
                    {
                        currentCup = cups.Dequeue();
                    }
                    else { break; }
                }

                if (currentCup <= currentBottle)
                {
                    wastedWater += currentBottle - currentCup;
                    if (cups.Count > 0 && bottles.Count > 0)
                    {
                        currentCup = cups.Dequeue();
                    }
                    else { break; }

                    if (bottles.Count > 0 && currentCup > 0)
                    {
                        currentBottle = bottles.Pop();
                    }
                    else { break; }
                }
                else
                {
                    currentCup -= currentBottle;
                    if (bottles.Count > 0 && currentCup > 0)
                    {
                        currentBottle = bottles.Pop();
                    }
                    else { break; }
                }
            }

            if (bottles.Count != 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            if (cups.Count != 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
