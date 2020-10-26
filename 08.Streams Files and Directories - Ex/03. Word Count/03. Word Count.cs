using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            using (StreamReader stream = new StreamReader("../../../words.txt"))
            {
                input = stream.ReadToEnd();
            }
            string[] wordsInput = input.ToLower().Split(new string[] { " ", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> words = new Dictionary<string, int>();
            for (int i = 0; i < wordsInput.Length; i++)
            {
                words[wordsInput[i]] = 0;
            }

            using (StreamReader stream = new StreamReader("../../../text.txt"))
            {
                while ((input = stream.ReadLine()) != null)
                {
                    string[] separators = { " ", "-", ",", ".", "!", "?" };
                    wordsInput = input.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < wordsInput.Length; i++)
                    {

                        if (words.ContainsKey(wordsInput[i]))
                        {
                            words[wordsInput[i]]++;
                        }
                    }
                }
            }

            var wordsOrdered = words.OrderByDescending(x => x.Value);

            using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
            {
                foreach (var item in wordsOrdered)
                {
                    writer.WriteLine($"{item.Key} -{item.Value}");
                    //Console.WriteLine($"{item.Key} -{item.Value}");
                }
            }
        }
    }
}
