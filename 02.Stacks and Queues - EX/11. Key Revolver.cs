using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());
            int barrel = int.Parse(Console.ReadLine());
            int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> bullet = new Stack<int>(line);
            line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(line);
            int inteligence = int.Parse(Console.ReadLine());
            int countBullet = 0;
            int countBarrel = barrel;


            while(bullet.Count > 0 && locks.Count>0)
            {
                if (bullet.Pop() <= locks.Peek())
                {
                    locks.Dequeue();
                    countBullet++;
                    Console.WriteLine("Bang!");
                    countBarrel--;
                    if (countBarrel < 1)
                    {
                        if (bullet.Count > 0)
                        {
                            Console.WriteLine("Reloading!");
                            if (bullet.Count >= barrel)
                            {
                                countBarrel = barrel;
                            }
                            else
                            {
                                countBarrel = bullet.Count;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ping!");
                    countBullet++;
                    countBarrel--;
                    if (countBarrel < 1)
                    {
                        if (bullet.Count > 0)
                        {
                            Console.WriteLine("Reloading!");
                            if (bullet.Count >= barrel)
                            {
                                countBarrel = barrel;
                            }
                            else
                            {
                                countBarrel = bullet.Count;
                            }
                        }
                    }
                }
            }

            if (bullet.Count >= 0 && locks.Count < 1)
            {
                Console.WriteLine($"{bullet.Count} bullets left. Earned ${inteligence-countBullet*price}");
                return;
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
