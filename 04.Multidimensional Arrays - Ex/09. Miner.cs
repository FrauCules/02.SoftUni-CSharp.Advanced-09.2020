using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split();
            char[,] table = new char[n, n];
            
            ReadMatrix(table);
            //PrintMatrix(table);

            int posRow = 0;
            int posCol = 0;
            int sumCoals = 0;
            int allCoals = 0;
            bool endGame = false;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++) // колко въглища има в цялото поле
                {
                    if (table[i, j] == 'c')
                    {
                        allCoals++;
                    }

                    if (table[i, j] == 's') // намиране на стартовата позиция
                    {
                        posRow = i;
                        posCol = j;
                    }
                }
            }

            for (int i = 0; i < command.Length; i++)
            {
                
                if (command[i] == "up")
                {
                    if (posRow - 1 >= 0)
                    {
                        posRow--;                        
                        if(table[posRow, posCol] == 'e')
                        {
                            endGame = true;
                            break;
                        }
                        if (table[posRow, posCol] == 'c')
                        {
                            sumCoals++;
                            table[posRow, posCol] = '*';
                        }

                    }
                    continue;
                }

                if (command[i] == "right")
                {
                    if (posCol + 1 <n)
                    {
                        posCol++;                        
                        if (table[posRow, posCol] == 'e')
                        {
                            endGame = true;
                            break;
                        }
                        if (table[posRow, posCol] == 'c')
                        {
                            sumCoals++;
                            table[posRow, posCol] = '*';
                        }
                    }
                    continue;
                }

                if (command[i] == "down")
                {
                    if (posRow + 1 < n)
                        posRow++;
                    {
                        if (table[posRow, posCol] == 'e')
                        {
                            endGame = true;
                            break;
                        }
                        if (table[posRow, posCol] == 'c')
                        {
                            sumCoals++;
                            table[posRow, posCol] = '*';
                        }

                    }
                    continue;
                }

                if (command[i] == "left")
                {
                    if (posCol - 1 >=0)
                        posCol--;
                    {
                        if (table[posRow, posCol] == 'e')
                        {
                            endGame = true;
                            break;
                        }
                        if (table[posRow, posCol] == 'c')
                        {
                            sumCoals++;
                            table[posRow, posCol] = '*';
                        }

                    }
                    continue;
                }
            }

            if (endGame)
            {
                Console.WriteLine($"Game over! ({posRow}, {posCol})");
                return;
            }

            if (allCoals == sumCoals)
            {
                Console.WriteLine($"You collected all coals! ({posRow}, {posCol})");
            }
            else
            {
                Console.WriteLine($"{allCoals-sumCoals} coals left. ({posRow}, {posCol})");
            }
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
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
