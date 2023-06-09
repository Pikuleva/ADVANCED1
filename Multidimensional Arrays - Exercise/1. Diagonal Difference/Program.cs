using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            int rows;
            ReadMatrix(out matrix, out rows);
            int sumFirst = 0;
            int sumSecond = 0;
            for (int row = 0; row < rows; row++)
            {
                sumFirst += matrix[row, row];
            }
            for (int row = rows - 1; row >= 0; row--)
            {
                sumSecond += matrix[row, rows - row - 1];

            }
            int sum = sumSecond - sumFirst;
            Console.WriteLine(Math.Abs(sum));
        }

        private static void ReadMatrix(out int[,] matrix, out int rows)
        {
            int size = int.Parse(Console.ReadLine());
            matrix = new int[size, size];
            rows = size;
            int cols = size;

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
