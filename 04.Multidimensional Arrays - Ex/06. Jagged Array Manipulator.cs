using System;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];  // инициилизира броя на редовете, колоните са динамични и не знаеш колко ще са

            ReadJagged(jagged);

            for (int i = 0; i < jagged.Length-1; i++)
            {
                if(jagged[i].Length== jagged[i + 1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                        jagged[i+1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] /= 2;
                    }
                    for (int j = 0; j < jagged[i+1].Length; j++)
                    {
                        jagged[i+1][j] /= 2;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split();
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);

                if (input[0]== "Add"&&row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                {
                    jagged[row][col] += double.Parse(input[3]);
                }

                if (input[0] == "Subtract" && row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                {
                    jagged[row][col] -= double.Parse(input[3]);
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
