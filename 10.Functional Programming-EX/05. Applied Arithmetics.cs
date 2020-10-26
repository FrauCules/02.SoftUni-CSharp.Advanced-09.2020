using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that executes some mathematical operations on a given collection. 
            On the first line you are given a list of numbers. 
            On the next lines you are passed different commands that you need to apply to all the numbers in the list:
                •	"add" -> add 1 to each number
                •	"multiply" -> multiply each number by 2
                •	"subtract" -> subtract 1 from each number
                •	"print" -> print the collection
                •	"end" -> ends the input 
                Use functions.                 */
            Func<int, int> addNum = p => p + 1;
            Func<int, int> multiplyNum = p => p * 2;
            Func<int, int> subtractNum = p => p - 1;

            List<int> nums = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        nums = nums.Select(x => addNum(x)).ToList();
                        break;
                    case "multiply":
                        nums = nums.Select(multiplyNum).ToList();
                        break;
                    case "subtract":
                        nums = nums.Select(subtractNum).ToList();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums)); ;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
        
