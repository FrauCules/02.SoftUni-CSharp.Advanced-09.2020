using System;
using System.Collections.Generic;

namespace _09.Demo2_GenericsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations<List<int>, List<List<int>>> x;  // възможна структура
            
            List<Operations<int, string>> list = new List<Operations<int, string>>(); // възможна структура
            list.Add(new Operations<int, string>());               //!!!!!!!!!!!!!!!!!!!!!!!!!
            
            var oparation1 = new Operations<int, string>();
            Console.WriteLine(oparation1.AreEqual(5,"6"));
            Console.WriteLine(oparation1.ToStringResult(5,"6"));

            var oparation2 = new Operations<string, int>();
            Console.WriteLine(oparation2.AreEqual("5", 5));
            Console.WriteLine(oparation2.ToStringResult("hop", 5));
        }
    }
    class Operations<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public bool AreEqual(T1 first, T2 second)
        {
            return first.Equals(second);
        }

        public string ToStringResult(T1 first, T2 second)
        {
            return first.ToString() + second.ToString();
        }
    }
}
