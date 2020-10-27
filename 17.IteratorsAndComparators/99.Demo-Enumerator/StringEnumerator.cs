using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _09.Demo_Enumerator
{
    public class StringEnumerator : IEnumerator<string>
    {
        private int index = -1; // в началото е -1
        public StringEnumerator(string[] array)
        {
            Array = array;
        }

        public string[] Array { get; set; }
        public string Current => Array[index]; // връща елемента, на който сме

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext() // отиваме на сл.елемент
        {
            index++;
            if (Array.Length <= index)
            {
                return false;  // не можем да отидем на сл.елемент, стигнали сме края
            }
            return true;
        }

        public void Reset() // връщаме се в начална позиция
        {
            index = -1;
        }
    }
}
