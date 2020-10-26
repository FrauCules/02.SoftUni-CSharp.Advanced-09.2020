using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
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
                int[] colElements = Console.ReadLine().Split(", ")
                                      .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = colElements[col];
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
