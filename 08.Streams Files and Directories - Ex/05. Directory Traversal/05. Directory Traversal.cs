using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05._Directory_Traversal
{
    /*5.	Directory Traversal
            Write a program that traverses a given directory for all files with the given extension. 
            Search through the first level of the directory only and write information about each found file in report.txt. 
            The files should be grouped by their extension. Extensions should be ordered by the count of their files descending, 
            then by name alphabetically. Files under an extension should be ordered by their size. report.txt should be saved on the Desktop. 
            Ensure the desktop path is always valid, regardless of the user.*/

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> fileInfo = new Dictionary<string, Dictionary<string, double>>();
            
            DirectoryInfo dirInfo=new DirectoryInfo("../../../");
            FileInfo[] files=dirInfo.GetFiles();

            foreach (var item in files)
            {
                if (!fileInfo.ContainsKey(item.Extension))
                {
                    fileInfo[item.Extension] = new Dictionary<string, double>();
                }
                fileInfo[item.Extension].Add(item.Name, item.Length/1024.00);
            }

            using (StreamWriter writer = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/DirectoryTraversal.txt"))
            {
                foreach (var item in fileInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(item.Key);
                    foreach (var items in item.Value.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"--{items.Key} - {items.Value:f3} kb");
                    }
                }
            }
        }
    }
}
