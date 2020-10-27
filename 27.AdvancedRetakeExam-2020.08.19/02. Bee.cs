using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace _02._BEE
{
    public class Program
    {
        public class Position
        {
            public Position(int row, int col)
            {
                Col = col;
                Row = row;
            }

            public int Row { get; set; }

            public int Col { get; set; }

            public bool IsSafe(int rowCount, int colCount) // оставаме ли в матрицата? ДА - true / НЕ - false
            {
                if (Row < 0 || Col < 0)
                {
                    return false;
                }
                if (Row >= rowCount || Col >= colCount)
                {
                    return false;
                }

                return true;
            }

            public bool CheckOtherSideMovement(int rowCount, int colCount) // ако сме излезли извън матрицата, приключваме
            {
                if (Row < 0 || Col < 0|| Row >= rowCount|| Col >= colCount)
                {
                    return false;
                }

                return true;
            }

            public static Position GetDirection(string command) // определя посоката със стъпка 1
            {
                int row = 0;
                int col = 0;
                if (command == "left")
                {
                    col = -1;
                }
                if (command == "right")
                {
                    col = 1;
                }
                if (command == "up")
                {
                    row = -1;
                }
                if (command == "down")
                {
                    row = 1;
                }

                return new Position(row, col);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //размера на матрицата
            char[,] matrix = new char[n, n];
            string command;
            bool gameOver = false;

            ReadMatrix(matrix);
            var player = GetPlayerPosition(matrix);
            int pollinate = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                var oldPosition = player;
                matrix[oldPosition.Row, oldPosition.Col] = '.';

                if (!MovePlayer(player, command, n))
                {
                    gameOver = true;
                    break;
                }
                while (matrix[player.Row, player.Col] == 'O')
                {
                    matrix[player.Row, player.Col] = 'B';
                    oldPosition = player;
                    matrix[oldPosition.Row, oldPosition.Col] = '.';
                    if (!MovePlayer(player, command, n))
                    {
                        gameOver = true;
                        break;
                    }
                    if (matrix[player.Row, player.Col] == 'f')
                    {
                        pollinate++;
                    }
                    
                    matrix[player.Row, player.Col] = 'B';
                }

                if (matrix[player.Row, player.Col] == 'f')
                {
                    pollinate++;
                }
                
                matrix[player.Row, player.Col] = 'B';
            }

            if (gameOver)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (pollinate >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinate} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5-pollinate} flowers more");
            }
            
            PrintMatrix(matrix);

        }

        static bool MovePlayer(Position player, string command, int n) // 
        {
            Position movement = Position.GetDirection(command); // в каква посока се движим
            player.Row += movement.Row; // изчислява новата позиция на реда
            player.Col += movement.Col; // изчислява новата позиция на колоната
            if(player.Row >= 0 && player.Row < n && player.Col >= 0 && player.Col < n)
            {
                return true;  // връща новата позиция
            }
            return false;
        }
        static Position GetPlayerPosition(char[,] matrix) // намиране позицията на играча
        {
            Position position = null;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        position = new Position(row, col);
                    }
                }
            }

            return position;
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }   // четем матрицата от конзолата

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
        }   // разпечатваме матрицата
    }
}
