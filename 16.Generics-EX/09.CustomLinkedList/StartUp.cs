using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 5; i++)
            {
                list.AddFirst(i);
            }
            

            for (int i = 15; i < 20; i++)
            {
                list.AddLast(i);
            }

            //list.PrintList();
            Console.WriteLine("Remove element = 2");
            list.Remove(2); // изтрива елемент със стойност 2
            
            //list.PrintList();

            Console.WriteLine("Console.WriteLine(list.ToArray().Length);");
            Console.WriteLine(list.ToArray().Length);


            LinkedList<string> listString = new LinkedList<string>();
            listString.AddFirst("absde");
            listString.AddLast("zxcvb");


            //Console.WriteLine("Pop().Value);");
            //Console.WriteLine(list.Pop().Value);
            //Console.WriteLine("Print list:");
            //list.PrintList();

            //Console.WriteLine("Print Reverse");
            //list.ReversePrintList();

            //Node<int> currentHead = list.head;
            //Console.WriteLine("CurrentHead " + currentHead.Value);
            //Console.WriteLine("Next " + currentHead.Next.Value);
            //Console.WriteLine("Next " + currentHead.Next.Next.Value);
            //Console.WriteLine("Next " + currentHead.Next.Next.Next.Value);

            //while (currentHead != null)
            //{
            //    Console.WriteLine(currentHead.Value);
            //    currentHead = currentHead.Next;
            //}

            //LinkedList<string> listString = new LinkedList<string>();
            //listString.AddFirst(new Node<string>("abc"));
            //listString.AddFirst(new Node<string>("bcd"));
            //listString.AddFirst(new Node<string>("cde"));
            //listString.AddFirst(new Node<string>("deg"));
            //listString.AddFirst(new Node<string>("egh"));
            Console.WriteLine("listString.ToArray().Length");
            Console.WriteLine(listString.ToArray().Length);
            //listString.PrintList();

            Console.WriteLine();
            //Node<string> currentHeadString = listString.Head;
            //Console.WriteLine("CurrentHead " + currentHeadString.Value);
            //Console.WriteLine("Next " + currentHeadString.Next.Value);
            //Console.WriteLine("Next " + currentHeadString.Next.Next.Value);
            //Console.WriteLine("Next " + currentHeadString.Next.Next.Next.Value);

            Console.WriteLine();
            Console.WriteLine("RemoveFirst");
            Console.WriteLine("RemoveLast");
            listString.RemoveFirst();
            listString.RemoveLast();

            //while (currentHeadString != null)
            //{
            //    Console.WriteLine(currentHeadString.Value);
            //    currentHeadString = currentHeadString.Next;
            //}
        }
    }
}
