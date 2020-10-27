using System;
using System.Collections.Generic;

namespace _2._Book_Worm
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> letters = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                letters.Push(input[i]);
            }

            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            ReadMatrix(matrix);
            int posRow = PositionX(matrix);
            int posCol = PositionY(matrix);

            string direction;
            while ((direction=Console.ReadLine())!="end")
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
                            letters.Pop();
                        }
                        break;
                    case "up":
                        matrix[posRow, posCol] = '-';
                        if (posRow - 1 < 0)
                        {
                            letters.Pop();
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
                            letters.Pop();
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
                            letters.Pop();
                        }
                        break;
                }

                if (matrix[posRow, posCol] != '-')
                {
                    letters.Push(matrix[posRow, posCol]);
                    matrix[posRow, posCol] = 'P';
                }
                else
                {
                    matrix[posRow, posCol] = 'P';
                }
            }

            Stack<char> result = new Stack<char>();
            while(letters.Count>0)
            {
                result.Push(letters.Pop());
            }

            Console.WriteLine(string.Join("",result));
            PrintMatrix(matrix);
        }

        private static int PositionX(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] =='P')
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
                    if (matrix[row, col] == 'P')
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
                char[] currentRow = Console.ReadLine().ToCharArray();
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
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
