using System;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = list[0];
            int col = list[1];
            char[,] table = new char[row, col];

            ReadMatrix(table);

            int posRow = 0;
            int posCol = 0;
            bool endGame = false;
            bool won = false;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == 'P') // намиране на стартовата позиция
                    {
                        posRow = i;
                        posCol = j;
                    }
                }
            }

            char[] command = Console.ReadLine().ToCharArray();
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'U')
                {
                    if (posRow - 1 >= 0)
                    {
                        table[posRow, posCol] = '.';
                        posRow--;
                        if (table[posRow, posCol] == 'B')
                        {
                            endGame = true;
                        }
                        else
                        {
                            table[posRow, posCol] = 'P';
                        }
                    }
                    else
                    {
                        table[posRow, posCol] = '.';
                        won = true;
                    }
                }

                if (command[i] == 'R')
                {
                    if (posCol + 1 < col)
                    {
                        table[posRow, posCol] = '.';
                        posCol++;
                        if (table[posRow, posCol] == 'B')
                        {
                            endGame = true;
                        }
                        else
                        {
                            table[posRow, posCol] = 'P';
                        }
                    }
                    else
                    {
                        table[posRow, posCol] = '.';
                        won = true;
                    }
                }

                if (command[i] == 'D')
                {
                    if (posRow + 1 < row)
                    {
                        table[posRow, posCol] = '.';
                        posRow++;
                        if (table[posRow, posCol] == 'B')
                        {
                            endGame = true;
                        }
                        else
                        {
                            table[posRow, posCol] = 'P';
                        }
                    }
                    else
                    {
                        table[posRow, posCol] = '.';
                        won = true;
                    }
                }

                if (command[i] == 'L')
                {
                    if (posCol - 1 >= 0)
                    {
                        table[posRow, posCol] = '.';
                        posCol--;
                        if (table[posRow, posCol] == 'B')
                        {
                            endGame = true;
                        }
                        else
                        {
                            table[posRow, posCol] = 'P';
                        }
                    }
                    else
                    {
                        table[posRow, posCol] = '.';
                        won = true;
                    }
                }

                for (int x = 0; x < table.GetLength(0); x++) // маркира съседните клетки като нови зайчета
                {
                    for (int y = 0; y < table.GetLength(1); y++)
                    {
                        if (table[x, y] == 'B') // проверка само за клетките в които има зайчета и ще се размножават
                        {
                            if (x - 1 >= 0) // ако горната клетка е в обхвата
                            {
                                if (table[x - 1, y] == 'P') // ако горната клетка е заета от играча - играта свършва
                                {
                                    endGame = true;
                                    table[x - 1, y] = 'N';
                                }

                                if (table[x - 1, y] == '.')
                                {
                                  table[x - 1, y] = 'N';
                                }
                            }

                            if (x + 1 < row)
                            {
                                if (table[x + 1, y] == 'P')
                                {
                                    endGame = true;
                                    table[x + 1, y] = 'N';
                                }

                                if (table[x + 1, y] == '.')
                                {
                                    table[x + 1, y] = 'N';
                                }
                            }

                            if (y - 1 >= 0)
                            {
                                if (table[x, y - 1] == 'P')
                                {
                                    endGame = true;
                                    table[x, y - 1] = 'N';
                                }

                                if (table[x, y - 1] == '.')
                                {
                                    table[x, y - 1] = 'N';
                                }
                            }

                            if (y + 1 < col)
                            {
                                if (table[x, y + 1] == 'P')
                                {
                                    endGame = true;
                                    table[x, y + 1] = 'N';
                                }

                                if (table[x, y + 1] == '.')
                                {
                                    table[x, y + 1] = 'N';
                                }
                            }
                        }
                    }
                }

                for (int x = 0; x < table.GetLength(0); x++) // прави маркираните нови клетки на зайчета
                {
                    for (int y = 0; y < table.GetLength(1); y++)
                    {
                        if(table[x, y] == 'N')
                            table[x, y] = 'B';
                    }
                }

                if (won || endGame) // Ако играчът е срищнал зайче или ако е излязъл извън полето
                {
                    break;
                }
            }

            PrintMatrix(table);

            if (won)
            {
                Console.WriteLine($"won: {posRow} {posCol}");
                return;
            }

            if (endGame)
            {
                Console.WriteLine($"dead: {posRow} {posCol}");
            }
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
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
