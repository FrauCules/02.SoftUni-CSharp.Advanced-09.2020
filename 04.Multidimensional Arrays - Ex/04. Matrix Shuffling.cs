using System;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int nRow = int.Parse(line[0]);
            int nCol = int.Parse(line[1]);
            string[,] matrix = new string [nRow, nCol];
            string input;

            ReadMatrix(matrix);
            
            while ((input = Console.ReadLine()) != "END")
            {
                if (!ValidationCommand(input, nRow, nCol))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string[] list = input.Split();
                int r1= int.Parse(list[1]);
                int c1 = int.Parse(list[2]);
                int r2 = int.Parse(list[3]);
                int c2 = int.Parse(list[4]);

                string firstElement = matrix[r1,c1];
                string secondElement = matrix[r2, c2];

                matrix[r1, c1] = secondElement;
                matrix[r2, c2] = firstElement;

                PrintMatrix(matrix);
            }
        }

        private static bool ValidationCommand(string command, int nRow, int nCol)
        {
            // команда от 5 позиции
            // проверка за валидност на индексите

            string[] list = command.Split();

            if(list.Length==5
                && list[0]=="swap" && int.Parse(list[1]) < nRow
                && int.Parse(list[2]) < nCol
                && int.Parse(list[3]) < nRow
                && int.Parse(list[4]) < nCol)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void ReadMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentRow = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine(matrix[row, matrix.GetLength(1) - 1]);
            }
        }
    }
}
