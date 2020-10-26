using System;
using System.IO;

namespace _07.Folders_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Console.ReadLine();
            Console.WriteLine(GetDirectoriesSize(directoryPath, 0));
        }

        private static double GetDirectoriesSize(string directoryPath,  int identation)
        {
            double sum = 0;
            string[] files = Directory.GetFiles(directoryPath);

            string[] directories = Directory.GetDirectories(directoryPath);
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine($"{new string(' ',identation)}{directories[i]}");
                sum += GetDirectoriesSize(directories[i], identation +3);
                //Directory.Delete(directories[i]); // изтрива всички директории
            }

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{new string('-', identation)}{info.Name} --> {info.Length} bytes");
                sum += info.Length;
                // File.Delete(files[i]); // изтрива всички файлове
            }

            return sum;
        }
    } 
}
