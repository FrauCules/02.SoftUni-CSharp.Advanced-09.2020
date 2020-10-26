using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[n[0], n[1]];
            ReadMatrix(matrix);

            int posRow = 0;
            int posCol = 0;
            int maxSum = 0;

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    int currentSum = matrix[i,j]+ matrix[i+1, j] + matrix[i, j+1] + matrix[i+1, j+1];
                    if (currentSum > maxSum)
                    {
                        posRow = i;
                        posCol = j;
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine(matrix[posRow,posCol] +" "+  matrix[posRow,posCol+1]);
            Console.WriteLine(matrix[posRow+1, posCol] + " " + matrix[posRow+1, posCol + 1]);
            Console.WriteLine(maxSum);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
