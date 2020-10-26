using System;
using System.Collections.Generic;

namespace _10._Crossroads // 85% - не минава тест 6
{
    class Program
    {
        static void Main(string[] args)
        {
            int green = int.Parse(Console.ReadLine());
            int window = int.Parse(Console.ReadLine());
            Queue<string> list = new Queue<string>();
            string line;
            var lastCar="";
            int numCar = 0;

            while ((line = Console.ReadLine()) != "END")
            {
                if (line != "green")
                {
                    list.Enqueue(line);
                    continue;
                }
                else
                {
                    int curentGreen = green;
                    while (curentGreen > 0 && list.Count != 0)
                    {
                        lastCar = list.Dequeue();
                        curentGreen -= lastCar.Length;
                        if (curentGreen + window >= 0)
                        {
                            numCar++;
                        }
                        else
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{lastCar} was hit at {lastCar.Substring(lastCar.Length+curentGreen+window,1)}.");
                            return;
                        }
                    }
                }
            }
             
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{numCar} total cars passed the crossroads.");
        }
    }
}
