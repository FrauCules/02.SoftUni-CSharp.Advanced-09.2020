using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{
    class CustomStack
    {
        private const int INITIAL_CAPACITY = 4;
        private const string EMPTY_STACK_EXC_MSG = "Stack is empty"; // правя къстъм съобщение, което викам при грешка

        private int[] items;

        public CustomStack() // конструктора задава първоначалния капацитет на 4
        {
            this.items = new int[INITIAL_CAPACITY];
        }

        public int Count { get; private set; } //  съдържа боя на значещите елементи

        public void Push(int item)  // добавя елемент в масива
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(EMPTY_STACK_EXC_MSG);
            }

            int poppedIten =this.items[this.Count - 1];
            this.items[this.Count-1] = default;
            this.Count--;

            return poppedIten;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(EMPTY_STACK_EXC_MSG);
            }

            int poppedIten = this.items[this.Count - 1];
           
            return poppedIten;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                // action(this.items[i]); // от първия към посления
                action(this.items[this.Count -i -1]); // от последния към първия
            }
        }

        private void Resize()    // удвоява капацитета на масива
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            items = copy;
        }
    }
}
