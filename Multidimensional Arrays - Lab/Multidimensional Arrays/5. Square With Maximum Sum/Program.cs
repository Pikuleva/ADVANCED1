using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[size[0], size[1]];
            int sumMax = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < rows; i++)
            {
                int[] elements = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = elements[j];                 
                }
            }
            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < cols; j++)
                {
                    int currSum = 0;
                    if (j+1 > matrix.GetLength(1)-1 || i+1 > matrix.GetLength(0)-1)
                    {
                        continue;
                    }
                    currSum += matrix[i,j];
                    currSum += matrix[i,j+1];
                    currSum += matrix[i+1,j];
                    currSum += matrix[i+1,j+1];
                    if (sumMax<currSum)
                    {
                        sumMax = currSum;
                        maxCol = j;
                        maxRow = i;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxRow,maxCol]} {matrix[maxRow, maxCol+1]}");
            Console.WriteLine($"{matrix[maxRow+1, maxCol]} {matrix[maxRow+1,maxCol+1]}");
            Console.WriteLine(sumMax);
        }
    }
}
