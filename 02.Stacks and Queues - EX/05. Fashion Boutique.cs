using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> box = new Stack<int>(list);
            int capacityRack = int.Parse(Console.ReadLine());
            int numBox = 1; 
            int currentCapacityRack = capacityRack;

            while (box.Count>0)
            {
                if (currentCapacityRack >= box.Peek())
                {
                    currentCapacityRack -= box.Pop();
                }
                else
                {
                    numBox++;
                    currentCapacityRack = capacityRack;
                }
            }
            Console.WriteLine(numBox);
        }
    }
}
