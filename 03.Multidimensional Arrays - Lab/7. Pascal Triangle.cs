using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] tab = new long[n][];
            
            ReadJagged(tab);
            FillJagged(tab);
            PringJagged(tab);
        }


        
        private static void ReadJagged(long[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = new long[row+1];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = 1;
                }
            }
        }

        private static void FillJagged(long[][] jagged)
        {
            for (int row = 2; row < jagged.Length; row++)
            {
                for (int col = 1; col < jagged[row].Length-1; col++)
                {
                    jagged[row][col] = jagged[row-1][col-1]+ jagged[row-1][col];
                }
            }
        }

        private static void PringJagged(long[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write("{0} ", jagged[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
