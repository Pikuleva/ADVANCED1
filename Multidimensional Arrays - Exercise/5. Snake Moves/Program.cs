﻿using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            char[,] snake = new char[rows, cols];

            string input = Console.ReadLine();
            int index = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row%2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        snake[row, col] = input[index];
                        index++;
                        if (index == input.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        snake[row, col] = input[index];
                        index++;
                        if (index == input.Length)
                        {
                            index = 0;
                        }
                    }
                }
            
            }
            PrintMatrix(snake);

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
