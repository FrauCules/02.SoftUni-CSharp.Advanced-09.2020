using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Demo_CustomListGeneric
{
    public class CustomList<T>
    {
        private T[] array;
        private int index = 0;

        public CustomList()
        {
            array = new T[8];
        }

        public IEnumerator<T> GetEnumerator() // вкл. го, за да работи foreach !!!
        {
            Console.WriteLine("Starting:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("In the yield Method:");
                yield return array[i];
            }
        }

        public void Add(T element)
        {
            array[index] = element;
            index++;
        }
    }
}
