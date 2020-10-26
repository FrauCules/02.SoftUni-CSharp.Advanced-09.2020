using System;
using System.Collections.Generic;
using System.Text;

namespace _98.Demo1
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void AddHead(Node node)
        {
            node.Next = Head;
            Head = node;
        }

        public void PrintList()
        {
            Node currentNode = Head;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
