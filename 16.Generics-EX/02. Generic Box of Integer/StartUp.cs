using System;

namespace GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int value = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(value);
               
                Console.WriteLine(box);
            }
        }
    }
}
