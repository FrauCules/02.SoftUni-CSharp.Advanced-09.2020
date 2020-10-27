using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presents = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            ReadMatrix(matrix);
            int posRow = PositionX(matrix);
            int posCol = PositionY(matrix);
            int niseKids = 0;

            string direction;
            while ((direction = Console.ReadLine()) != "Christmas morning")
            {
                switch (direction)
                {
                    case "down":
                        matrix[posRow, posCol] = '-';
                        if (posRow + 1 < n)
                        {
                            posRow++;
                        }
                        else
                        {
                            // 
                        }
                        break;
                    case "up":
                        matrix[posRow, posCol] = '-';
                        if (posRow - 1 < 0)
                        {
                            //
                        }
                        else
                        {
                            posRow--;
                        }
                        break;
                    case "left":
                        matrix[posRow, posCol] = '-';
                        if (posCol - 1 < 0)
                        {
                            //
                        }
                        else
                        {
                            posCol--;
                        }
                        break;
                    case "right":
                        matrix[posRow, posCol] = '-';
                        if (posCol + 1 < n)
                        {
                            posCol++;
                        }
                        else
                        {
                            //
                        }
                        break;
                }

                if (matrix[posRow, posCol] == '-'|| matrix[posRow, posCol] == 'X')
                {
                    matrix[posRow, posCol] = 'S';
                }
                else if(matrix[posRow, posCol] == 'V')
                {
                    matrix[posRow, posCol] = 'S';
                    presents--;
                    niseKids++;
                    if (presents == 0)
                        break;
                }
                else if(matrix[posRow, posCol] == 'C')
                {
                    matrix[posRow, posCol] = 'S';
                    if (posRow + 1 < n && (matrix[posRow + 1, posCol]=='V'|| matrix[posRow + 1, posCol] == 'X'))
                    {
                        if (matrix[posRow + 1, posCol] == 'V')
                            niseKids++;
                        presents--;
                        if (presents == 0)
                        matrix[posRow+1, posCol] = '-';
                            break;
                    }
                    if (posRow - 1 >= 0 && (matrix[posRow - 1, posCol] == 'V' || matrix[posRow - 1, posCol] == 'X'))
                    {
                        if (matrix[posRow - 1, posCol] == 'V')
                            niseKids++;
                        matrix[posRow - 1, posCol] = '-';
                        presents--;
                        if (presents == 0)
                            break;
                    }
                    if (posCol + 1 < n && (matrix[posRow, posCol+1] == 'V' || matrix[posRow, posCol+1] == 'X'))
                    {
                        if (matrix[posRow, posCol+1] == 'V')
                            niseKids++;
                        matrix[posRow, posCol+1] = '-';
                        presents--;
                        if (presents == 0)
                            break;
                    }
                    if (posCol - 1 >= 0 && (matrix[posRow, posCol-1] == 'V' || matrix[posRow, posCol-1] == 'X'))
                    {
                        if (matrix[posRow, posCol-1] == 'V')
                            niseKids++;
                        matrix[posRow, posCol-1] = '-';
                        presents--;
                        if (presents == 0)
                            break;
                    }
                }
            }

            if (presents == 0)
            {
                Console.WriteLine("Santa ran out of presents!");
            }
            PrintMatrix(matrix);

            int countNiceKids = CountNiceKids(matrix);

            if(countNiceKids==0)
            {
                Console.WriteLine($"Good job, Santa! {niseKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {countNiceKids} nice kid/s.");
            }
            
        }

        private static int CountNiceKids(char[,] matrix)
        {
            int result = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'V')
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        private static int PositionX(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        return row;
                    }
                }
            }

            return -1;
        }

        private static int PositionY(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        return col;
                    }
                }
            }

            return -1;
        }
        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
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
