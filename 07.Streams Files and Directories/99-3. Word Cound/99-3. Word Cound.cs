using System;
using System.IO;

namespace _90_3._Word_Cound
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"..\..\..\sample.txt";
            string word = "C#";
            try
            {
                StreamReader reader = new StreamReader(fileName);
                using (reader)
                {
                    int occurrences = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        int index = line.IndexOf(word);
                        while (index != -1)
                        {
                            occurrences++;
                            index = line.IndexOf(word, (index + 1));
                        }
                        line = reader.ReadLine();
                    }
                    Console.WriteLine("The word {0} occurs {1} times.", word, occurrences);
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file {0}.", fileName);
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can not read the file {0}.", fileName);
            }
        }
    }
}

