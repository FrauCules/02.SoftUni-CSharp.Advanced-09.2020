using System;
using System.IO;

namespace _08._MemoryStream
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(new byte[] { 1, 2, 3 }, 0, 3);
            var buffer = new byte[3];
            stream.Seek(0, SeekOrigin.Begin);
            stream.Read(buffer, 0, 3);
            Console.WriteLine(String.Join(" ",buffer));
        }
    }
}
