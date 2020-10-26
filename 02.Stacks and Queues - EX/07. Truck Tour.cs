using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Queue<int> fuel = new Queue<int>();
            Queue<int> km = new Queue<int>();
            int index = 0;
            bool fl = false;

            for (int i = 0; i < num; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                fuel.Enqueue(input[0]);
                km.Enqueue(input[1]);
            }

            for (int i = 0; i < num; i++)  
            {
                index = i;
                fl = true;
                Queue<int> fuelTest = new Queue<int>(fuel);
                Queue<int> kmTest = new Queue<int>(km);
                for (int j = 0; j < i; j++)
                {
                    fuelTest.Enqueue(fuelTest.Dequeue());
                    kmTest.Enqueue(kmTest.Dequeue());
                }

                int currentFuel = 0; // моментното к-во гориво
                for (int x = 0; x < num; x++)
                {
                    if ((currentFuel + fuelTest.Peek())< kmTest.Peek())
                    {
                        //Console.WriteLine($"--{i}-- {currentFuel} + {fuelTest.Peek()} = {currentFuel + fuelTest.Peek()} < {kmTest.Peek()}");
                        fuelTest.Enqueue(fuelTest.Dequeue());
                        kmTest.Enqueue(kmTest.Dequeue());
                        currentFuel = 0;
                        fl = false;
                        break;
                    }
                    else
                    {
                        //Console.WriteLine($" {currentFuel} + {fuelTest.Peek()} - {kmTest.Peek()} = {currentFuel + fuelTest.Peek()-kmTest.Peek()}");
                        currentFuel += (fuelTest.Peek() - kmTest.Peek());
                        fuelTest.Enqueue(fuelTest.Dequeue());
                        kmTest.Enqueue(kmTest.Dequeue());
                    }
                }
                if (fl)
                {
                    Console.WriteLine(index);
                    break;
                }
            }
        }
    }
}
