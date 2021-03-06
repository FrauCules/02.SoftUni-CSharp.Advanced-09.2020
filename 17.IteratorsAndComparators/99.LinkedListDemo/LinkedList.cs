﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class LinkedList : IEnumerable<Node>
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public bool IsReversed { get; set; }

        public void Reverse()
        {
            var oldHead = Head;
            Head = Tail;
            Tail = oldHead;
        }

        public void ForEach(Action<Node> action)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public bool Contains(int value)
        {
            bool isFound = false;
            ForEach(node =>
            {
                if (node.Value == value) isFound = true;
            });

            return isFound;
        }

        public bool Remove(int value)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                if(currentNode.Value == value)
                {
                    currentNode.Previous.Next = currentNode.Next;
                    currentNode.Next.Previous = currentNode.Previous;
                    return true;
                }
                currentNode = currentNode.Next;
            }

            return false;
        }

        public Node[] ToArray()
        {
            List<Node> list = new List<Node>();
            this.ForEach(node => list.Add(node));
            return list.ToArray();
        }

        public void AddHead(Node newHead)
        {
            if(Head == null)
            {
                Head = newHead;
                Tail = newHead;
            }
            else
            {
                newHead.Next = Head;
                Head.Previous = newHead;
                Head = newHead;
            }

        }

        public void AddLast(Node newTail)
        {
            if (Tail == null)
            {
                Tail = newTail;
                Head = newTail;
            }
            else
            {
                newTail.Previous = Tail;
                Tail.Next = newTail;
                Tail = newTail;
            }
        }

        public Node RemoveFirst()
        {
            var oldHead = this.Head;
            this.Head = this.Head.Next;
            Head.Previous = null;
            return oldHead;
        }

        public Node RemoveLast()
        {
            var oldTail = this.Tail;
            Tail = this.Tail.Previous;
            Tail.Next = null;
            return oldTail;
        }

        public int Peek()
        {
            return this.Head.Value;
        }
        public void PrintList()
        {
            this.ForEach(node => Console.WriteLine(node.Value));
        }

        public void ReversePrintList()
        {
            Node currentNode = Tail;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }
        }

        public IEnumerator<Node> GetEnumerator() // Вариант 1 - номия начин
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                yield return currentNode;
                currentNode = currentNode.Next;
            }
        }

        //public IEnumerator<Node> GetEnumerator()    // Вариант 2
        //{
        //    return new LinkedListEnumerator(Head);
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LinkedListEnumerator : IEnumerator<Node> // вариант 2 - стария начин - много сложен
        {
            private Node head;
            public LinkedListEnumerator(Node head)
            {
                this.head = head;
            }
            public Node Current => head;

            object IEnumerator.Current => head;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                head = head.Next;
                return head.Next != null;
            }

            public void Reset()
            {
            }
        }
    }
}
