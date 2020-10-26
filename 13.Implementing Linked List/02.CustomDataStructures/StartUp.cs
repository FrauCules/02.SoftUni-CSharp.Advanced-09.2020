using System;

namespace CustomDataStructures
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomList myCustomList = new CustomList();

            for (int i = 0; i < 5; i++)
            {
                myCustomList.Add(i);
            }

            myCustomList.Insert(1, 6);

            myCustomList.RemoveAt(1);

            Console.WriteLine(myCustomList.Contains(3));
            myCustomList.Swap(1,3);
            Console.WriteLine(myCustomList); // CW работи с обекти и сам вика ToString();


            Console.WriteLine("---- Stack ----");
            CustomStack myCustomStack = new CustomStack();
            for (int i = 0; i < 5; i++)
            {
                myCustomStack.Push(i);
                //Console.WriteLine(myCustomStack.Peek());
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(myCustomStack.Peek());
            //    Console.WriteLine(myCustomStack.Pop());
            //}

            myCustomStack.ForEach(x => // вариант за печат 1
            {
                Console.WriteLine(x);
            });

            myCustomStack.ForEach(Console.WriteLine); // вариант за печат 2, защото самия Console.WriteLine e Action
        }
    }
}
 