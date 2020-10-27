using System;

namespace _09.Demo_CustomListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(5);
            list.Add(7);
            // този list не може да се  форийчне ако не вкл. метод <public IEnumerator<T> GetEnumerator() >                  

            foreach (var item in list)
            {
                Console.WriteLine("In the foreach");
                Console.WriteLine(item);
            }
        }
    }
}
