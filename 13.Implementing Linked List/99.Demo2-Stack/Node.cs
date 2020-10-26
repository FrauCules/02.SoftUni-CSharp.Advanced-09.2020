using System;
using System.Collections.Generic;
using System.Text;

namespace _98.Demo1
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public Node Next { get; set; }
    }
}
