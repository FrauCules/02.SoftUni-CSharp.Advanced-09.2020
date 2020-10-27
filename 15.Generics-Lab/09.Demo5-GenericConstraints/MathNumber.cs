using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Demo5_GenericConstraints
{
    class MathNumber<T> where T : struct, // Приема само числа
        IComparable,
        IComparable <T>,
        IConvertible,
        IEquatable<T>,
        IFormattable
    {
        private T[] array;
        
        public T Max(T first, T second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public T GetMin()
        {
            T min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min.CompareTo(array[i]) < 0)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
