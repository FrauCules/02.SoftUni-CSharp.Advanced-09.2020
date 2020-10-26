using System;
using System.IO;
using System.Text;

namespace _97._ByteAsString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Tova e text. Това  е текст.";
            using(FileStream stream = new FileStream("../../../output.txt", FileMode.Create))
            {
                byte[] byteText = Encoding.UTF8.GetBytes(text);
                stream.Write(byteText, 0, byteText.Length);
            }
        }
    }
}
