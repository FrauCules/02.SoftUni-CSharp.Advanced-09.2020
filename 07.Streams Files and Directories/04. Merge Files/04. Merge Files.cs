using System;
using System.IO;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            using (StreamReader reader = new StreamReader("../../../FileOne.txt"))
            {
                while((input = reader.ReadLine())!= null)
                {

                }
            }
        }
    }
}
