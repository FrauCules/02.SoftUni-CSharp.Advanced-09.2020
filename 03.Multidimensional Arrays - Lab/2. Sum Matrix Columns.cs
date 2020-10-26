using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ")
                     .Select(int.Parse).ToArray(); // задай броя на редовете и на колоните
            int[,] matrix = new int[sizes[0], sizes[1]]; // създай матрицата
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++) // задай елементите на матрицата
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
