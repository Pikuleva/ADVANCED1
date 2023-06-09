using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;
            char[,] matrix = new char[rows, cols];
            bool find = false;

            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            char searchChar = char.Parse(Console.ReadLine());
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (searchChar == matrix[row,col])
                    {
                        find = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
            }
            if (!find)
            {
                Console.WriteLine($"{searchChar} does not occur in the matrix");
            }
        }
    }
}
