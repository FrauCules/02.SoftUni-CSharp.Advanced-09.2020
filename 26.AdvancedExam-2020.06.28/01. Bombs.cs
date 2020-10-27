using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Stack<int> bomcCasings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Dictionary<string, int> bombPouch = new Dictionary<string, int>();
            bombPouch.Add("Datura Bombs", 0);
            bombPouch.Add("Cherry Bombs", 0);
            bombPouch.Add("Smoke Decoy Bombs", 0);
            bool GameOver = false;
            string newBomb;


            while (bombEffects.Count>0 && bomcCasings.Count > 0)
            {
                int sum = bombEffects.Peek() + bomcCasings.Peek();
                if (sum == 40)
                {
                    newBomb = "Datura Bombs";
                    if (GameOver = IsDone(newBomb, bombPouch, bombEffects, bomcCasings))
                    {
                        break;
                    }
                }
                else if (sum == 60)
                {
                    newBomb = "Cherry Bombs";
                    if (GameOver = IsDone(newBomb, bombPouch, bombEffects, bomcCasings))
                    {
                        break;
                    }
                }
                else if (sum == 120)
                {
                    newBomb = "Smoke Decoy Bombs";
                    if (GameOver = IsDone(newBomb, bombPouch, bombEffects, bomcCasings))
                    {
                        break;
                    }
                }
                else
                {
                    int num = bomcCasings.Pop() - 5;
                    bomcCasings.Push(num);
                }

            }

            if (GameOver)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count >0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bomcCasings.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bomcCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var item in bombPouch.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static bool IsDone(string newBomb, Dictionary<string, int> bombPouch, Queue<int> bombEffects, Stack<int> bomcCasings)
        {
            bombPouch[newBomb]++;
            bombEffects.Dequeue();
            bomcCasings.Pop();
           
            foreach (var item in bombPouch)
            {
                if (item.Value < 3)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
