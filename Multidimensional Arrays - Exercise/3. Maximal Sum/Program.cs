using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = ReadMatrix();
            int maxSum = 0;
            int[,] bestMatrix = new int[3, 3];
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                int currSum = 0;
                int maxRow = 0;
                int maxCol = 0;
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    currSum = 0;
                    currSum += matrix[row, col];
                    currSum += matrix[row+1, col];
                    currSum += matrix[row+2, col];
                    currSum += matrix[row, col+1];
                    currSum += matrix[row, col+2];
                    currSum += matrix[row+1, col+1];
                    currSum += matrix[row+2, col+2];
                    currSum += matrix[row+1, col+2];
                    currSum += matrix[row+2, col+1];
                    if (currSum>maxSum)
                    {
                        maxSum = currSum;
                        maxRow = row;
                        maxCol = col;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                bestMatrix[i, j] = matrix[maxRow+i, maxCol+j];
                                
                            }

                        }
                                                    
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = 0; row < bestMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < bestMatrix.GetLength(1); col++)
                {
                    Console.Write($"{bestMatrix[row,col]} ");
                }
                Console.WriteLine();
            }



        }

        private static int[,] ReadMatrix()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];
            
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
