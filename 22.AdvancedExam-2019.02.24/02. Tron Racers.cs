using System;
using System.ComponentModel.Design;

namespace _02._Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            ReadMatrix(matrix);
            int posFrow = PositionX(matrix, 'f');
            int posFcol = PositionY(matrix, 'f');
            int posSrow = PositionX(matrix, 's');
            int posScol = PositionY(matrix, 's');

            bool gameOver = false;
            while (!gameOver)
            {
                string[] command = Console.ReadLine().Split();
                string directionF = command[0];
                string directionS = command[1];

                switch (directionF)
                {
                    case "down":
                        if (posFrow + 1 < n)
                        {
                            posFrow++;
                        }
                        else
                        {
                            posFrow=0;
                        }
                        break;
                    case "up":
                        if (posFrow - 1 < 0)
                        {
                            posFrow = n-1;
                        }
                        else
                        {
                            posFrow--;
                        }
                        break;
                    case "left":
                        if (posFcol - 1 < 0)
                        {
                            posFcol = n - 1;
                        }
                        else
                        {
                            posFcol--;
                        }
                        break;
                    case "right":
                        if (posFcol + 1 < n)
                        {
                            posFcol++;
                        }
                        else
                        {
                            posFcol = 0;
                        }
                        break;
                }

                if(matrix[posFrow, posFcol] == 's')
                {
                    matrix[posFrow, posFcol] = 'x';
                    break;
                }
                else
                {
                    matrix[posFrow, posFcol] = 'f';
                }

                switch (directionS)
                {
                    case "down":
                        if (posSrow + 1 < n)
                        {
                            posSrow++;
                        }
                        else
                        {
                            posSrow = 0;
                        }
                        break;
                    case "up":
                        if (posSrow - 1 < 0)
                        {
                            posSrow = n - 1;
                        }
                        else
                        {
                            posSrow--;
                        }
                        break;
                    case "left":
                        if (posScol - 1 < 0)
                        {
                            posScol = n - 1;
                        }
                        else
                        {
                            posScol--;
                        }
                        break;
                    case "right":
                        if (posScol + 1 < n)
                        {
                            posScol++;
                        }
                        else
                        {
                            posScol = 0;
                        }
                        break;
                }

                if (matrix[posSrow, posScol] == 'f')
                {
                    matrix[posSrow, posScol] = 'x';
                    break;
                }
                else
                {
                    matrix[posSrow, posScol] = 's';
                }

            }

            PrintMatrix(matrix); ;
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
