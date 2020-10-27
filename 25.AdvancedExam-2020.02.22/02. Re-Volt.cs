using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace _02._Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //размера на матрицата
            char[,] matrix = new char[n, n];
            int numCommand = int.Parse(Console.ReadLine()); // колко команди ще бъдат подадени
            if (numCommand <= 0)
            {
                Console.WriteLine("Player lost!");
                return;
            }
            bool isWon = false;

            ReadMatrix(matrix);
            int posRow = PositionX(matrix, 'f');
            int posCol = PositionY(matrix, 'f'); 
            Queue<string> repeat = new Queue<string>(); // ако попадне на бонус пази същата команда, за да я повтори
            string direction;

            for (int i = 0; i < numCommand; i++)
            {
                int oldRowPos = posRow;
                int oldColPos = posCol;
                if (repeat.Count>0)
                {
                    direction = repeat.Dequeue();
                }
                else
                {
                    direction = Console.ReadLine();
                }
                switch (direction)
                {
                    case "down":
                        if (posRow + 1 < n)
                        {
                            if(!IsTrap(matrix, posRow + 1, posCol))
                            {
                                posRow++;
                            }
                        }
                        else
                        {
                            if (!IsTrap(matrix, 0, posCol))
                            {
                                posRow = 0;
                            }
                        }
                        break;
                    case "up":
                        if (posRow - 1 < 0)
                        {
                            if (!IsTrap(matrix, n - 1, posCol)) // ако новата позиция е КАПАН - оставаме на старата позиция
                            {
                                posRow = n - 1;
                            }
                        }
                        else
                        {
                            if (!IsTrap(matrix, posRow - 1, posCol))    // ако новата позиция е КАПАН - оставаме на старата позиция
                            {
                                posRow--;
                            }
                        }
                        break;
                    case "left":
                        if (posCol - 1 < 0)
                        {
                            if (!IsTrap(matrix, posRow, n-1))   // ако новата позиция е КАПАН - оставаме на старата позиция
                            {
                                posCol = n - 1;
                            }
                        }
                        else
                        {
                            if (!IsTrap(matrix, posRow, posCol - 1))    // ако новата позиция е КАПАН - оставаме на старата позиция
                            {
                                posCol--;
                            }
                        }
                        break;
                    case "right":
                        if (posCol + 1 < n)
                        {
                            if (!IsTrap(matrix, posRow, posCol + 1))    // ако новата позиция е КАПАН - оставаме на старата позиция
                            {
                                posCol++;
                            }
                        }
                        else
                        {
                            if (!IsTrap(matrix, posRow, 0)) // ако новата позиция е КАПАН - оставаме на старата позиция
                            {
                                posCol=0;
                            }
                        }
                        break;
                }

                if (matrix[posRow, posCol] == 'B')
                {
                    repeat.Enqueue(direction);
                    matrix[oldRowPos, oldColPos] = '-'; // предвата позиция става '-'
                    continue;
                }
                else if(matrix[posRow, posCol] == 'F')
                {
                    matrix[posRow, posCol] = 'f';   // новата позиция става 'f'
                    if (matrix[oldRowPos, oldColPos] != 'B')    // ако старата позиция не е била 'B' - става '-'
                        matrix[oldRowPos, oldColPos] = '-';
                    Console.WriteLine("Player won!");
                    isWon = true;
                    break; // приключва 
                }
                else
                {
                    matrix[posRow, posCol] = 'f';           // новата позиция става 'f'
                    if (matrix[oldRowPos, oldColPos]!='B')
                        matrix[oldRowPos, oldColPos] = '-'; // // ако старата позиция не е била 'B' - става '-'
                }
            }

            if (!isWon)
            {
                Console.WriteLine("Player lost!");
            }
            PrintMatrix(matrix);
        }

        private static bool IsTrap(char[,] matrix, int r, int c)
        {
            if (matrix[r, c] == 'T')
                return true;
            else
                return false;
        }

        private static int PositionX(char[,] matrix, char player)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == player)
                    {
                        return row;
                    }
                }
            }

            return -1;
        }

        private static int PositionY(char[,] matrix, char player)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == player)
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
