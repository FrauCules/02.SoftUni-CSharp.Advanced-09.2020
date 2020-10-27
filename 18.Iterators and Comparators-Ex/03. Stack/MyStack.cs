using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public MyStack()
        {
            this.stack = new List<T>();
        }

        public int Count
            => this.stack.Count;

        public void Push(T item)
        {
            this.stack.Add(item);
        }

        public T Pop()
        {
            try
            {
                //T lastItems = this.stack[Count - 1];   // Вар.1
                //T lastItem = stack.Last();             // Вар.2
                
                T lastItems = this.stack[^1];            // Вар.3  [^1] връща последния елемент, [^2] връща предпоследния елемент и т.н. !!!!!!!
                stack.RemoveAt(stack.Count - 1);    // така маха последния елемент
                
                return lastItems;

            }
            catch (Exception)
            {

                throw new InvalidOperationException("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count-1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
