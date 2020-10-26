using System;
using System.IO;
using System.Linq;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            // Вариант 1:
            //using (StreamWriter writer = new StreamWriter("../../../output.txt"))
            //{
            //    for (int i = 0; i < lines.Length; i++)
            //    {
            //        string line = lines[i];
            //        writer.WriteLine($"Line {i + 1}: {line} ({CountOfLetters(line)})({CountOfPunctuationMarks(line)})");
            //    }
            //}

            // Вариант 2:
            string[] result = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                result[i] = $"Line {i + 1}: {line} ({CountOfLetters(line)})({CountOfPunctuationMarks(line)})";
            }
            File.WriteAllLines("../../../output.txt", result);
        }

        static int CountOfLetters(string line)
        {
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i]; 
                if (Char.IsLetter(ch))
                {
                    count++;
                }
            }

            return count;
        }

        static int CountOfPunctuationMarks(string line)
        {
            char[] punctuationMarks = {'-', '.', ',', '!', '?', '\'', ';',':'};
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                if (punctuationMarks.Contains(ch))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
