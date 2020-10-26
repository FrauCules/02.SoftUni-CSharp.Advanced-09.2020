using System;
using System.IO;
using System.IO.Compression;

namespace _06._Zip_and_Extract
{
    /*6.	Zip and Extract
            Write a program that creates a zip file in a given directory and extracts it in another one. 
            Use the copyMe.png file from your resources and zip it in a directory of your choice. 
            Extract the zip file in another directory, again, by your choice.
            Hint - use the ZipFile class */

    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:/Users/Мария/source/repos/Digit_to_Text_DE", @"C:/Users/Мария/source/repos/myZipFile.zip");
            Directory.CreateDirectory(@"C:/Users/Мария/source/repos/NewFolder");
            ZipFile.ExtractToDirectory(@"C:/Users/Мария/source/repos/myZipFile.zip", @"C:/Users/Мария/source/repos/NewFolder");
        }
    }
}
