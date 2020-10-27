using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace GenericBoxofInteger
{
    public class Box<T>
    {
        public T Element { get; set; }
        public Box(T element)
        {
            this.Element = element;
        }

        public override string ToString()
        {
            return $"{Element.GetType()}: {Element}";
        }

    }
}
