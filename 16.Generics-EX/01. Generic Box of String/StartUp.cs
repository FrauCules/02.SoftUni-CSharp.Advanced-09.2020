using System;

namespace GenericBoxofString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Create a generic class Box that can be initialized with any type and store the value. 
            //Override the ToString() method and print the type and stored value.
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string value = Console.ReadLine();
                
                Box<string> box = new Box<string>(value);
                //Console.WriteLine(box.ToString());
                Console.WriteLine(box);
            }
        }
    }
}
