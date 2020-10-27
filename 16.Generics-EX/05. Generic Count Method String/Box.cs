using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable
    {
        public List<T> Values { get; set; } = new List<T>();

        public Box(List<T> list)
        {
            this.Values = list;
        }

        public int GetCountOfGreater(T value)
        {
            int count = 0;
            foreach (T item in Values)
            {
                if (value.CompareTo(item) < 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void Swap(int first, int second)
        {
            T index = this.Values[first];
            this.Values[first] = this.Values[second];
            this.Values[second] = index;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in this.Values)
            {
                sb.Append($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
