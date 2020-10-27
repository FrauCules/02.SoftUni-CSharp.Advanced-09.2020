using System;
using System.Collections.Generic;

namespace GenericsClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(); // при компилация ще приеме тип int
            list.Add(5);
            list.Add(6); // може да приема само int

            GenericList<string> listString = new GenericList<string>(); // при компилация ще приеме тип string
            listString.Add("5");
            listString.Add("6");


            //ObjectList list = new ObjectList();
            //list.Add(5);
            //list.Add(5);
            //list.Add("55");
            //list.Add(new Program());
        }
    }
    class Student
    {
        public int Age { get; set; }
    }
}
