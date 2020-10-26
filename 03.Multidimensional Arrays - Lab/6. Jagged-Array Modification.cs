using System;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];

            ReadJagged(jagged);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split();
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);

                if (input[0] == "Add")
                {
                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += double.Parse(input[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                }

                if (input[0] == "Subtract")
                {
                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= double.Parse(input[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                }
            }

            PringJagged(jagged);
        }

        private static void ReadJagged(double[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split(' ');
                jagged[row] = new double[inputNumbers.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(inputNumbers[col]);
                }
            }
        }


        private static void PringJagged(double[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write("{0} ", jagged[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}

        
