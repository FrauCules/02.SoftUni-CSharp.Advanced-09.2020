using System;

namespace _02._Snake
{
    class Program
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
                if (Row < 0 || Col < 0 || Row >= rowCount || Col >= colCount)
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
            bool foodsDone =false;

            ReadMatrix(matrix);
            var player = GetPosition(matrix, 'S');
            int foods = 0;

            while (true)
            {
                matrix[player.Row, player.Col] = '.';
                command = Console.ReadLine();
                if(MovePlayer(player, command, n))
                {
                    //matrix[player.Row, player.Col] = 'S';
                }
                else
                {
                    gameOver = true;
                    break;
                }
                
                if(matrix[player.Row, player.Col] == '*')
                {
                    foods++;
                    if (foods == 10)
                    {
                        matrix[player.Row, player.Col] = 'S';
                        foodsDone = true;
                        break;
                    }
                }


                if (matrix[player.Row, player.Col] == 'B')
                {
                    matrix[player.Row, player.Col] = '.';
                    player = GetPosition(matrix, 'B');
                }
            }

            if (gameOver)
            {
                Console.WriteLine("Game over!");
            }

            if (foodsDone)
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foods}");

            PrintMatrix(matrix);
        }
        static bool MovePlayer(Position player, string command, int n) // 
        {
            Position movement = Position.GetDirection(command); // в каква посока се движим
            player.Row += movement.Row; // изчислява новата позиция на реда
            player.Col += movement.Col; // изчислява новата позиция на колоната
            if (player.Row >= 0 && player.Row < n && player.Col >= 0 && player.Col < n)
            {
                return true;  // връща новата позиция
            }
            return false;
        }
        static Position GetPosition(char[,] matrix, char ch) // намиране позицията на играча
        {
            Position position = null;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == ch) // позоцията със съответното означение
                    {
                        position = new Position(row, col);
                        return position;
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

