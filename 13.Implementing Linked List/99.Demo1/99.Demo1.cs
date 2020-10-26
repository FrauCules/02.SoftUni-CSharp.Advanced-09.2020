using System;

namespace _98.Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            for (int i = 0; i < 20; i++)
            {
                list.AddHead(new Node(i));
            }

            list.PrintList();
        }
    }
}
