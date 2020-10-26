using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int nRow = int.Parse(line[0]);
            int nCol = int.Parse(line[1]);
            char[,] matrix = new char[nRow, nCol];
            readMatrix(matrix);
            int sumResult = 0;

            for (int i = 0; i < nRow-1; i++)
            {
                for (int j = 0; j < nCol-1; j++)
                {
                    if (matrix[i,j] == matrix[i, j+1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1]) 
                    {
                        sumResult++;
                    }
                }
            }

            Console.WriteLine(sumResult);
        }


        private static void readMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }

}
