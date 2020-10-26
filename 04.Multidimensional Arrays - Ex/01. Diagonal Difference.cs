using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            ReadMatrix(n, matrix);

            int sumD1 = 0;
            int sumD2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumD1 += matrix[i, i];
            }
            
            for (int i = 0; i < n; i++)
            {
                sumD2 += matrix[i, n - 1 - i];
            }
            
            Console.WriteLine(Math.Abs(sumD1-sumD2));
        }

      

        private static void ReadMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
