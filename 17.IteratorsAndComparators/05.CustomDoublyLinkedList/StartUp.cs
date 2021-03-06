﻿using System;
using System.Collections.Generic;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 5; i++)
            {
                list.AddFirst(new Node<int>(i));
            }

            for (int i = 15; i < 20; i++)
            {
                list.AddLast(new Node<int>(i));
            }

            list.PrintList();
            Console.WriteLine("Remove element = 2");
            list.Remove(2); // изтрива елемент със стойност 2
            list.PrintList();

            Console.WriteLine("Console.WriteLine(list.ToArray().Length);");
            Console.WriteLine(list.ToArray().Length);

            Console.WriteLine("Pop().Value);");
            Console.WriteLine(list.Pop().Value);
            Console.WriteLine("Print list:");
            list.PrintList();

            Console.WriteLine("Print Reverse");
            list.ReversePrintList();

            Node<int> currentHead = list.Head;
            Console.WriteLine("CurrentHead " + currentHead.Value);
            Console.WriteLine("Next " + currentHead.Next.Value);
            Console.WriteLine("Next " + currentHead.Next.Next.Value);
            Console.WriteLine("Next " + currentHead.Next.Next.Next.Value);

            while (currentHead != null)
            {
                Console.WriteLine(currentHead.Value);
                currentHead = currentHead.Next;
            }

            Console.WriteLine("----------- STRING ---------------");
            LinkedList<string> listString = new LinkedList<string>();
            listString.AddFirst(new Node<string>("abc"));
            listString.AddFirst(new Node<string>("bcd"));
            listString.AddFirst(new Node<string>("cde"));
            listString.AddFirst(new Node<string>("deg"));
            listString.AddFirst(new Node<string>("egh"));
            Console.WriteLine("Брой елементи:");
            Console.WriteLine(listString.ToArray().Length);
            listString.PrintList();

            Console.WriteLine("Remove element = abc");
            listString.Remove("abc"); // изтрива елемент със стойност abc
            Console.WriteLine();
            listString.PrintList();

            Console.WriteLine();
            //Node<string> currentHeadString = listString.Head;
            //Console.WriteLine("CurrentHead " + currentHeadString.Value);
            //Console.WriteLine("Next " + currentHeadString.Next.Value);
            //Console.WriteLine("Next " + currentHeadString.Next.Next.Value);
            //Console.WriteLine("Next " + currentHeadString.Next.Next.Next.Value);
            //Console.WriteLine("Console.WriteLine(listString.ToArray().Length);");
            //Console.WriteLine(listString.ToArray().Length);

            Console.WriteLine();
            Console.WriteLine("RemoveFirst");
            listString.RemoveFirst();
            Console.WriteLine("Брой елементи:");
            Console.WriteLine(listString.ToArray().Length);
            listString.PrintList();

            Console.WriteLine("RemoveLast");
            listString.RemoveLast();
            Console.WriteLine("Брой елементи:");
            Console.WriteLine(listString.ToArray().Length);
            listString.PrintList();


            Console.WriteLine("Pop().Value);");
            Console.WriteLine(listString.Pop().Value);
            Console.WriteLine("Print list:");
            listString.PrintList();

            //while (currentHeadString != null)
            //{
            //    Console.WriteLine(currentHeadString.Value);
            //    currentHeadString = currentHeadString.Next;
            //}
        }
    }


    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
    }


    public class LinkedList<T> where T : IComparable
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public void AddFirst(Node<T> nodeNewHead)
        {
            if (Head == null)
            {
                Head = nodeNewHead;
                Tail = nodeNewHead;
            }
            else
            {
                nodeNewHead.Next = Head;
                Head.Previous = nodeNewHead;
                Head = nodeNewHead;
            }
        }

        public void AddLast(Node<T> nodeNewTail)
        {
            if (Tail == null)
            {
                Tail = nodeNewTail;
                Head = nodeNewTail;
            }
            else
            {
                nodeNewTail.Previous = Tail;
                Tail.Next = nodeNewTail;
                Tail = nodeNewTail;
            }

        }

        public Node<T> RemoveFirst()
        {
            var oldHead = Head;
            Head = Head.Next;
            Head.Previous = null;
            return oldHead;
        }

        public Node<T> RemoveLast()
        {
            var oldTail = Tail;
            if (Tail == Head)
            {

            }
            Tail = Tail.Previous;
            Tail.Previous = Tail.Previous.Next;
            Tail.Next = null;
            return oldTail;
        }

        public void ForEach(Action<Node<T>> action)
        {
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public void PrintList()
        {
            this.ForEach(node => Console.WriteLine(node.Value));
        }

        public Node<T>[] ToArray()
        {
            List<Node<T>> listT = new List<Node<T>>();
            this.ForEach(node => listT.Add(node));
            return listT.ToArray();
        }

        public void ReverseForEach(Action<Node<T>> action)
        {
            Node<T> currentNode = Tail;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Previous;
            }
        }

        public void ReversePrintList()
        {
            this.ReverseForEach(node => Console.WriteLine(node.Value));
        }

        public void ReversePrintList_1()
        {
            Node<T> currentNode = Tail;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }
        }
        public void PrintList_1()
        {
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
        public Node<T> Pop()
        {
            Node<T> currentNode = Head;
            Head = currentNode.Next;
            currentNode.Next.Previous = currentNode.Previous;
            return currentNode;
        }

        public bool Contains(T value)
        {
            bool isFaund = false;
            ForEach(node =>
            {
                if (node.Value.Equals(value)) isFaund = true;
            });

            return isFaund;
        }

        public bool Remove(T value) // // Изтрива елемента със стойност value
        {
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    if (currentNode == Tail) // ако е последния елемент 
                    {
                        //var oldTail = this.Tail;
                        Tail = this.Tail.Previous;
                        Tail.Previous = Tail.Previous.Previous.Next;
                        Tail.Next = null;
                        //return oldTail;
                        //Tail = currentNode.Previous;                        // прехвърля връзките в двете посоки
                        //currentNode.Previous.Previous = currentNode.Previous.Previous.Next;
                        //currentNode.Previous.Previous.Next = null;
                        return true;
                    }
                    else
                    {
                        currentNode.Previous.Next = currentNode.Next;       // прехвърля връзките в двете посоки
                        currentNode.Next.Previous = currentNode.Previous;
                        return true;
                    }
                }
                currentNode = currentNode.Next;
            }

            return false;
        }
    }
}
