using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] present = new string[] {"Doll","Wooden train","Teddy bear","Bicycle"};
            List<int> magicNeede = new List<int> { 150, 250, 300, 400 };
            Dictionary<string, int> readyPresents = new Dictionary<string,int>();

            Stack<int> materials = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            Queue<int> magicLevel = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());
            
            while(materials.Count>0 && magicLevel.Count > 0)
            {
                // ако поредното число е 0 го премахваме
                if (materials.Peek() == 0 || magicLevel.Peek() == 0)
                {
                    if (materials.Peek() == 0)
                    {
                        materials.Pop();

                    }

                    if (magicLevel.Peek() == 0)
                    {
                        magicLevel.Dequeue();

                    }
                    continue;
                }

                // предните материал и маг.ниво са равни

                int multiplication = materials.Peek() * magicLevel.Peek();
                if (multiplication > 0)
                {
                    if (magicNeede.Contains(multiplication)) // има играчка с тази стойност
                    {
                        int index = magicNeede.IndexOf(multiplication);
                        if (readyPresents.ContainsKey(present[index]))
                        {
                            readyPresents[present[index]]++;
                        }
                        else
                        {
                            readyPresents.Add(present[index], 1);
                        }
                        materials.Pop();
                        magicLevel.Dequeue();
                        continue;
                    }
                    else
                    {
                        magicLevel.Dequeue();
                        int material = materials.Pop()+15;
                        materials.Push(material);
                        continue;
                    }
                }
                else
                {
                    int sum = materials.Pop() + magicLevel.Dequeue();
                    materials.Push(sum);
                }
            }

            if (readyPresents.ContainsKey("Doll") && readyPresents.ContainsKey("Wooden train") || readyPresents.ContainsKey("Teddy bear") && readyPresents.ContainsKey("Bicycle"))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            

            if (materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }

            if (magicLevel.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicLevel)}");
            }

            foreach (var item in readyPresents.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
