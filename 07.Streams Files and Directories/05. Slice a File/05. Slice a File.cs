using System;
using System.IO;
using System.Text;

namespace _05._Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            int pieceCount = 4; // !!! Поради някаква причина в началото на файла има 3 скрити служебни символи, които пропускам
            //using (FileStream reader = new FileStream("../../../sliceMe.txt", FileMode.Open))
            using (FileStream reader = new FileStream("../../../TextFile1.txt", FileMode.Open))
            {
                long size = reader.Length/pieceCount;
                reader.Position = 3;

                for (int i = 0; i < pieceCount; i++)
                {
                    using (var pieceStream = new FileStream($"../../../Part-{i+1}.txt", FileMode.Create))
                    {
                        byte[] buffer = new byte[size];
                        int count = 0;
                        
                        while (count < size)
                        {
                            reader.Read(buffer, 0, buffer.Length);
                            pieceStream.Write(buffer, 0, buffer.Length);
                            for (int j = 0; j < buffer.Length; j++)
                            {
                                Console.Write((char)buffer[j]);
                            }
                            count += buffer.Length;
                        }
                        Console.WriteLine();
                    }
                }
            }    
        }
    }
}
