using System;
using System.Collections.Generic;

namespace CustomDoublyLinkedList
{
    public class LinkedList<T> where T : IComparable
    {
        public class Node
        {
            public Node(T value)
            {
                Value = value;
            }

            public T Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
        }

        private Node head;
        private Node tail;

        //public T Head { get; set; }
        //public T Tail { get; set; }

        public int Count { get; private set; }

        public void AddFirst(T nodeNewHead)
        {
            var newHead = new Node(nodeNewHead);
            
            if (this.Count == 0)
            {
                this.head = this.tail = newHead;
            }
            else
            {
                newHead.Next = this.head;
                this.head.Previous = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T nodeNewTail)
        {
            var newTail = new Node(nodeNewTail);
            
            if (this.Count == 0)
            {
                this.tail = this.head = newTail;
            }
            else
            {
                newTail.Previous = this.tail;
                this.tail.Next = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T removeElement = this.head.Value;

            Node newHead = this.head.Next;
            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                newHead.Previous = null;
                this.head = newHead;
            }

            this.Count--;

            return removeElement;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T removeElement = this.tail.Value;

            Node newTail = this.tail.Next;
            if (this.Count == 1)
            {
                this.tail = this.head = null;
            }
            else
            {
                newTail.Next = null;
                this.tail = newTail;
            }

            this.Count--;

            return removeElement;
        }

        public void ForEach(Action<T> action)
        {
            Node currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public T[] ToArray()
        {
            T[] listT = new T[this.Count];

            var currentNode = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                listT[i] = currentNode.Value;
                currentNode = currentNode.Next;
            }
            
            return listT;
        }

        //public void PrintList(T item)
        //{
        //    Console.WriteLine(item);
        //    //this.ForEach(node => Console.WriteLine(node.Value));
        //}

        //public void ReverseForEach(Action<T> action)
        //{
        //    Node currentNode = this.tail;
        //    while (currentNode != null)
        //    {
        //        action(currentNode);
        //        currentNode = currentNode.Previous;
        //    }
        //}

        //public void ReversePrintList(T item)
        //{
        //    this.ReverseForEach(node => Console.WriteLine(node.Value));
        //}

        //public void ReversePrintList_1()
        //{
        //    Node currentNode = tail;
        //    while (currentNode != null)
        //    {
        //        Console.WriteLine(currentNode.Value);
        //        currentNode = currentNode.Previous;
        //    }
        //}
        //public void PrintList_1()
        //{
        //    Node currentNode = head;
        //    while (currentNode != null)
        //    {
        //        Console.WriteLine(currentNode.Value);
        //        currentNode = currentNode.Next;
        //    }
        //}
        //public Node Pop()
        //{
        //    Node currentNode = head;
        //    head = currentNode.Next;
        //    currentNode.Next.Previous = currentNode.Previous;
        //    return currentNode;
        //}

        //public bool Contains(T value)
        //{
        //    bool isFaund = false;
        //    ForEach(node =>
        //    {
        //        if (node.Value.Equals(value)) isFaund = true;
        //    });

        //    return isFaund;
        //}

        public bool Remove(T value) // // Изтрива елемента със стойност value
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    currentNode.Previous.Next = currentNode.Next;       // прехвърля връзките в двете посоки
                    currentNode.Next.Previous = currentNode.Previous;
                    return true;
                }
                currentNode = currentNode.Next;
            }

            return false;
        }
    }
}
