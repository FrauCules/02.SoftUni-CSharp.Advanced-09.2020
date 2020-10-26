using System;
using System.IO;

namespace _06._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Console.ReadLine();
            double sum = 0;
            string[] files = Directory.GetFiles(directoryPath);
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{info.FullName} --> {info.Length} bytes");
                sum += info.Length;
            }
            
            Console.WriteLine(sum);
        }
    }
}
