using System;
using System.IO;

namespace _99._StreamSecondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream("../../../words.txt",FileMode.Open))
            {
                stream.Position = 3;
                byte[] buffer = new byte[3];
                while (stream.Position < stream.Length)
                {
                    stream.Read(buffer, 0, buffer.Length);
                    for (int i = 0; i < buffer.Length ; i++)
                    {
                        Console.Write((char)buffer[i]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
