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
            int rowF = 0;
            int colF = 0;

            string line;
            while((line= Console.ReadLine())!= "Bloom Bloom Plow")
            {
                int[] newPpositionF = line.Split().Select(int.Parse).ToArray();
                int newRow = newPpositionF[0];
                int newCol = newPpositionF[1];
                if(newRow<0 || newRow>=dimention[0] || newCol<0 || newCol >= dimention[1])
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                rowF = newRow;
                colF = newCol;
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
                    if(col!=i)
                        matrix[row, i]++;
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if(row !=i)
                    matrix[i,col]++;
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
