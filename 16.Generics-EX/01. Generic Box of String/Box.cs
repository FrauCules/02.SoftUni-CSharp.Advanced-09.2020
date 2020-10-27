using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace GenericBoxofString
{
    public class Box<T>
    {
        //Create a generic class Box that can be initialized with any type and store the value. 
        //Override the ToString() method and print the type and stored value.
       
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
