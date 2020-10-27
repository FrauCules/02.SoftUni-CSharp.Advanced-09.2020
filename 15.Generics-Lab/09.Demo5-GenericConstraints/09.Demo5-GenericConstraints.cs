using System;
using System.Collections.Generic;

namespace _09.Demo5_GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpRequest<object> request = new HttpRequest<object>();

            Console.WriteLine("Hello World!");
        }
    }
}
