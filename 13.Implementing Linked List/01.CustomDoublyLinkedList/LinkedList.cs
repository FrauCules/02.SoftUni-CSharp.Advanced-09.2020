using System;
using System.Collections.Generic;

namespace CustomDoublyLinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddFirst(Node nodeNewHead)
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

        public void AddLast(Node nodeNewTail)
        {
            if(Tail== null)
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

        public Node RemoveFirst()
        {
            var oldHead = this.Head;
            this.Head = this.Head.Next;
            this.Head.Previous = null;
            return oldHead;
        }

        public Node RemoveLast()
        {
            var oldTail = this.Tail;
            Tail = this.Tail.Previous;
            Tail.Next = null;
            return oldTail;
        }

        public void ForEach(Action<Node> action)
        {
            Node currentNode = Head;
            while(currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public void PrintList()
        {
            this.ForEach(node => Console.WriteLine(node.Value));
        }

        public Node[] ToArray()
        {
            List<Node> list = new List<Node>();
            this.ForEach(node => list.Add(node));
            return list.ToArray();
        }

        public void ReverseForEach(Action<Node> action)
        {
            Node currentNode = Tail;
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
            Node currentNode = Tail;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }
        }
        public void PrintList_1()
        {
            Node currentNode = Head;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
        public Node Pop()
        {
            var oldHead = this.Head;
            this.Head = this.Head.Next;
            return oldHead;
        }

        public bool Contains(int value)
        {
            bool isFaund =false;
            ForEach(node =>
            {
                if (node.Value == value) isFaund = true;
            });

            return isFaund;
        }

        public bool Remove( int value) // // Изтрива елемента със стойност value
        {
            Node currentNode = Head;
            while(currentNode != null)
            {
                if(currentNode.Value == value)
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
