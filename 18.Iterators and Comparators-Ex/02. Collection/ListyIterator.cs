using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> :IEnumerable<T>
    {
        private List<T> list;
        private int index;

        public ListyIterator(List<T> listInitial)   // listInotial -ще ни бъде първоначалната колекция със съответните стойности /може да бъде и празна/
        {
            this.list = listInitial;
            this.index = 0;
        }

        public int Count
            => this.list.Count;

        public void Reset()
            => index = 0;

        public bool Move()
        {
            //should move an internal index position to the next index in the list. 
            //The method should return true, if it had successfully moved the index and false if there is no next index
            if (this.HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            // should return true, if there is a next index and false, if the index is already at the last element of the list.
            if (index < list.Count - 1) // има следващ елемент
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            // should print the element at the current internal index. 
            //Calling Print on a collection without elements should throw an appropriate exception 
            //with the message "Invalid Operation!".

            if (list.Count == 0) // ако лист е празен - печатаме грешка
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]); // ако в листа има елементи - печатаме настоящиа индекс
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            //while (index < Count)     // Вариант 1
            //{
            //    yield return list[index];

            //    if (!Move())
            //    {
            //        yield break; 
            //    }

            //}

            foreach (T item in list)        // Вариант 2 - по-краткия
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
