using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimention = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[,] matrix = new int[dimention[0], dimention[1]];
            FillMatrix(matrix);
            Queue<int> flowers = new Queue<int>();
            
            string line;
            while ((line = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] newPpositionF = line.Split().Select(int.Parse).ToArray();
                int rowF = newPpositionF[0];
                int colF = newPpositionF[1];
                if (rowF < 0 || rowF >= dimention[0] || colF < 0 || colF >= dimention[1])
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                matrix[rowF, colF] = 1;
                flowers.Enqueue(rowF);
                flowers.Enqueue(colF);
            }

            BloomBloomPlow(matrix, flowers);

            PrintMatrix(matrix);
        }

        private static void BloomBloomPlow(int[,] matrix, Queue<int> flowers)
        {
            while (flowers.Count > 0)
            {
                int row = flowers.Dequeue();
                int col = flowers.Dequeue();

                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (col != i)
                        matrix[row, i]++;
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (row != i)
                        matrix[i, col]++;
                }
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
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
