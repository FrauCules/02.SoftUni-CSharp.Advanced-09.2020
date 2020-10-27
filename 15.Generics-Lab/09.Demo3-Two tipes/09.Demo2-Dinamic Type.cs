using System;

namespace _09.Demo2_GenericsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var oparation1 = new Operations<int>();
            Console.WriteLine(oparation1.AreEqual(5,6));
            Console.WriteLine(oparation1.ToStringResult(5,6));
            Console.WriteLine(oparation1.GetType());
            Console.WriteLine(oparation1.GetHashCode());

            var oparation2 = new Operations<string>();
            Console.WriteLine(oparation2.AreEqual("5", "5"));
            Console.WriteLine(oparation2.ToStringResult("hop", "trop"));
            Console.WriteLine(oparation2.GetType());
            Console.WriteLine(oparation2.GetHashCode());
        }
    }
    class Operations<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public bool AreEqual(T first, T second)
        {
            return first.Equals(second);
        }

        public string ToStringResult(T first, T second)
        {
            return first.ToString() + second.ToString();
        }
    }
}
