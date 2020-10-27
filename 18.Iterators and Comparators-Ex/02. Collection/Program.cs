using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> iterator = null;
            string line;

            while ((line = Console.ReadLine()) != "END")
            {
                try          // опитай да изпълниш този код
                {
                    string[] input = line.Split();
                    string command = input[0];

                    switch (command)
                    {
                        case "Create":
                            List<string> elements = input.Skip(1).ToList();
                            iterator = new ListyIterator<string>(elements);
                            break;
                        case "Move":
                            Console.WriteLine(iterator.Move());
                            break;
                        case "Print":
                            iterator.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(iterator.HasNext());
                            break;
                        case "PrintAll":
                            foreach (var item in iterator)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            break;
                    }
                }
                catch (InvalidOperationException e)     // catch (Exception e) - ще прихваща и отпечатва всички грешка
                                                        // catch (InvalidOperationException e) - можем да конкретизираме типа на грешката, който да прихваща
                {
                    Console.WriteLine(e.Message); // отпечатва съобщението на грешката
                }      
            }
        }
    }
}
