using System;
using System.IO;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../Input.txt");

            using (reader)
            {
                int count = 0;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    while (line != null)
                    {
                        if(count%2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
