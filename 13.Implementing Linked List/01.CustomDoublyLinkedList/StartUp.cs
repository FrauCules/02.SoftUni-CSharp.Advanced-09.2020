using System;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            for (int i = 0; i < 5; i++)
            {
                list.AddFirst(new Node(i));
            }

            //for (int i = 15; i < 20; i++)
            //{
            //    list.AddLast(new Node(i));
            //}

            list.PrintList();

            list.Remove(2); // изтрива елемент със стойност 2
            list.PrintList();

            //list.RemoveFirst();
            //list.RemoveLast();
            //Console.WriteLine();
            //list.PrintList();

            //Console.WriteLine(list.ToArray().Length);


            //Console.WriteLine(list.Pop().Value);

            //list.PrintList();
            //list.ReversePrintList();

            //Node currentHead = list.Head;
            //Console.WriteLine("CurrentHead "+currentHead.Value);
            //Console.WriteLine("Next "+currentHead.Next.Value);
            //Console.WriteLine("Next "+currentHead.Next.Next.Value);
            //Console.WriteLine("Next "+currentHead.Next.Next.Next.Value);

            //while(currentHead != null)
            //{
            //    Console.WriteLine(currentHead.Value);
            //    currentHead = currentHead.Next;
            //}
        }
    }
}
