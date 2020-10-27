using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethod
{
    class GenericList
    {
        public bool Contains<T>(List<T> list, T element) //Можем да напаснем нашите дженерици Contains<T> с други дженерици (List<T> list, T element)
        {
            return list.Contains(element);
        }
    }
}
