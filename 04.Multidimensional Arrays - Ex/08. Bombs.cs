using System;
using System.Linq;

namespace _8._Bombs__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] table = new int[n, n];
            ReadMatrix(table);
            string[] bomb = Console.ReadLine().Split();
            int sum = 0;
            int aliveCells = 0;

            for (int i = 0; i < bomb.Length; i++)
            {
                int[] pos = bomb[i].Split(",").Select(int.Parse).ToArray();
                int row = pos[0];
                int col = pos[1];
                int bombLoad = table[row, col];
                if (bombLoad <= 0)
                {
                    continue;
                }

                if (row - 1 >= 0 && col - 1 >= 0 && table[row - 1, col - 1]>0)
                {
                    table[row - 1, col - 1] -= bombLoad;
                }

                if (row - 1 >= 0 && table[row - 1, col]>0)
                {
                    table[row - 1, col] -= bombLoad;
                }

                if (row - 1 >= 0 && col + 1 < n && table[row - 1, col + 1]>0)
                {
                    table[row - 1, col + 1] -= bombLoad;
                }

                if ( col + 1 < n && table[row, col + 1]>0)
                {
                    table[row, col + 1] -= bombLoad;
                }

                if (row + 1 < n && col + 1 < n && table[row + 1, col + 1]>0)
                {
                    table[row + 1, col + 1] -= bombLoad;
                }

                if ( row + 1 < n && table[row+1, col]>0)
                {
                    table[row+1, col] -= bombLoad;
                }

                if (row + 1 < n && col - 1 >= 0 && table[row + 1, col - 1]>0)
                {
                    table[row + 1, col - 1] -= bombLoad;
                }

                if (col - 1 >= 0 && table[row, col - 1]>0)
                {
                    table[row, col - 1] -= bombLoad;
                }

                table[row, col] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (table[i, j] > 0)
                    {
                        sum += table[i, j];
                        aliveCells++;
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            PrintMatrix(table);
        }

        
        private static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
