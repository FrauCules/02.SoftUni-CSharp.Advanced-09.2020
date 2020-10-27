using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create { e1 e2 …}  - void    -   Creates a ListyIterator from the specified collection.
            //                                    In case of a Create command without any elements, you should create a ListyIterator with an empty collection.
            //  Move                  boolean     This command should move the internal index to the next index.
            //  Print                 void        This command should print the element at the current internal index.
            //  HasNext               boolean     Returns whether the collection has a next element.
            //  END                   void        Stops the input.
            //Your program should catch any exceptions thrown because of the described validations - calling Print on an empty collection - and print their messages instead.

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
