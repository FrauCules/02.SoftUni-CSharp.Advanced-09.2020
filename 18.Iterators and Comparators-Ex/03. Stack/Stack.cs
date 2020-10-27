using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            string line;

            while ((line = Console.ReadLine()) != "END")
            {
                try          // опитай да изпълниш този код
                {
                    string[] input = line.Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);
                    string command = input[0];

                    switch (command)
                    {
                        case "Push":
                            List<int> elements = input.Skip(1).Select(int.Parse).ToList();
                            foreach (var item in elements)
                            {
                                myStack.Push(item);
                            }
                            break;
                        case "Pop":             // вместо Try-Catch може да сложим проверка преди да изпълним Pop()
                            myStack.Pop();
                            break;
                    }

                }
                catch (InvalidOperationException e)     // catch (Exception e) - ще прихваща и отпечатва всички грешка
                                                        // catch (InvalidOperationException e) - можем да конкретизираме типа на грешката, който да прихваща
                {
                    Console.WriteLine(e.Message); // отпечатва съобщението на грешката
                }

            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
