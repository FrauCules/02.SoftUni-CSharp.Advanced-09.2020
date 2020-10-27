using System;

namespace Tuple
{
    public class Tuple<T1, T2>
    {
        //private T1 item1;
        //private T2 item2;
        public Tuple(T1 first, T2 second)
        {
            this.Item1 = first;
            this.Item2 = second;
        }
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }


        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
