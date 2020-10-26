using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string line;
                    int count = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (count % 2 == 0)
                        {
                            Regex regex = new Regex("[-.,!?]");
                            line = regex.Replace(line, "@");
                            var array = line.Split().ToArray().Reverse();
                            writer.WriteLine(string.Join(" ", array));
                        }
                        count++;
                    }
                }
            } 
        }
    }
}
