using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GenericsClasses
{
    class ObjectList
    {
        private object[] internalArray;
        private int index = 0;

        public ObjectList()
        {
            internalArray = new object[8];
        }

        public void Add(object newElement)
        {
            internalArray[index] = newElement;
            index++;
            if(index == internalArray.Length)
            {
                // resize - трябва да увеличим големината на масива
            }
        }
    }
}
