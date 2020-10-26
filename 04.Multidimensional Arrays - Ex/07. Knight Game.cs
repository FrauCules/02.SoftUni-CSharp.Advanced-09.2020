using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            ReadMatrix(matrix);

            // r-1 c-2
            // r-1 c+2
            // r+1 c-2
            // r+1 c+2
            // r-2 c-1
            // r-2 c+1
            // r+2 c-1
            // r+2 c+1

            int deleteKnight = 0; // броя на атакуваните позиции
            
            // докато countAttack > 0
            while (true)
             {
                //countAttack = 0;
                int rowAttackPos = 0;
                int colAttackPos = 0;
                int countAttack = 0;
                int maxAttack = 0;
                int row = 0;
                int col = 0;

                for (row = 0; row < matrix.GetLength(0); row++)
                {
                    for (col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'K') // проверяваме само позициите на които има кон
                        {
                            countAttack = 0; // брой атаките от текущата позиция

                            // проверка дали възможната позиция за атака е в рамките на масива И дали има кон на позицията
                            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
                            {
                                countAttack++;
                            }

                            if (row - 1 >= 0 && col + 2 < matrix.GetLength(1) && matrix[row - 1, col + 2] == 'K')
                            {
                                countAttack++;
                            }

                            if (row + 1 < matrix.GetLength(0) && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
                            {
                                countAttack++;
                            }

                            if (row + 1 < matrix.GetLength(0) && col + 2 < matrix.GetLength(1) && matrix[row + 1, col + 2] == 'K')
                            {
                                countAttack++;
                            }

                            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
                            {
                                countAttack++;
                            }

                            if (row - 2 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row - 2, col + 1] == 'K')
                            {
                                countAttack++;
                            }

                            if (row + 2 < matrix.GetLength(0) && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
                            {
                                countAttack++;
                            }

                            if (row + 2 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1) && matrix[row + 2, col + 1] == 'K')
                            {
                                countAttack++;
                            }

                            // ако текущата позиция е събрала най-много атаки - запазваме позицията й и стойността на атаките
                            if (countAttack > maxAttack)
                            {
                                rowAttackPos = row;
                                colAttackPos = col;
                                maxAttack = countAttack;
                            }
                        }
                    }
                }

                // ако при поредното обхождане нямаме рагистирани атаки - прекъсваме цикъла 
                if (maxAttack == 0)
                {
                    break;
                }
                else
                {
                    // изтриваме коня с най-много атаки и продължаваме проверката
                    matrix[rowAttackPos, colAttackPos] = '0';
                    deleteKnight++; // увеличаваме брояча на изтритите коне
                }
            }

            Console.WriteLine(deleteKnight);
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
