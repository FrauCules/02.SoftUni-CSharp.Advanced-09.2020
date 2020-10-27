using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Demo5_GenericConstraints
{
    public class MathComparable<T> where T: IComparable<T>
    {
        public T Max(T first, T second)
        {
            if(first.CompareTo(second)>0)
            { 
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
