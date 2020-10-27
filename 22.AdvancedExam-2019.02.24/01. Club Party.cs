using System;
using System.Collections.Generic;

namespace _01._Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            // n – an integer specifying the halls' maximum capacity
            // Then you will be given input line which will contain English alphabet letters and numbers, separated by a single space
            // The input for the line should be read from the last inserted to the first one.
            // he letters represent the halls and the numbers – the people in a single reservation.
            // Companies of people should go in the halls. 
            // The first entered hall is the first which people are entering. 
            // Every reservation takes specific capacity, equal to its number.
            // Input:
            //  60
            // 1 20 b 20 20 a
            // Output
            // a-> 20, 20, 20

            int capacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            Stack<string> stack = new Stack<string>();    // пази входа отзад напред
            Queue<string> halls = new Queue<string>();    // пази реда и дали има отворена зала
            List<int> reservations = new List<int>();
            int count = 0;                                // колко човека има в текущата зала  

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 0) // 50    - 15 a 40 30 20 c 15 10 b

            {
                string currentInput = stack.Peek();
                if (char.IsDigit(currentInput[0])) // резервация ли е
                {
                    int reservation = int.Parse(currentInput);
                    if (halls.Count > 0)            // има ли отворена зала
                    {
                        if(count + reservation <= capacity) // отворената зала побира ли текущата резервация
                        {
                            reservations.Add(reservation); // ако ДА - добавяме я в списъка с влезлите резервации
                            count += reservation;
                        }
                        else   // ако залата прелива - разпечатваме текущата залата и влезлите разервации
                        {
                            Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ",reservations)}");
                            reservations.Clear();
                            count = 0;

                            if (halls.Count > 0)
                            {
                                reservations.Add(reservation); // ако ДА - добавяме я в списъка с влезлите резервации
                                count += reservation;
                            }
                        }
                    }  // ако няма отворена зала, пропускаме резервацията
                }
                else
                {
                    halls.Enqueue(currentInput);
                }
                stack.Pop();
            }
        }
    }
}
