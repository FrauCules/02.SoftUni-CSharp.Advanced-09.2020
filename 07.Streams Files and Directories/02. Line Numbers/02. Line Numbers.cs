using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../Input.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int count = 1;
                using (var writer = new StreamWriter("../../../Output.txt"))
                {
                    while (line != null)
                    {
                        writer.WriteLine(count + ". " + line);
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
