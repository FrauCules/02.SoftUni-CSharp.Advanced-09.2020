using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Demo5_GenericConstraints
{
    public class HttpRequest<T> where T:class  // изпращаме за явка по мрежата
    {
        public void Send(T data)
        {
            Console.WriteLine("Sending all the data to the WWWW" + data);
        }
    }
}
