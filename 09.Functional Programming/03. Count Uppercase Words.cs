using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        /* Write a program that reads a line of text from the console. Print all the words that start with an uppercase letter in the same order you've received them in the text.*/
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(s => s[0]==s.ToUpper()[0]).ToArray();
            Console.WriteLine(string.Join("\n",words));
        }
    }
}
