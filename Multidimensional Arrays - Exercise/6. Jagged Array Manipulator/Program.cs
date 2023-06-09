using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row  = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
            }
            for (int row = 0; row < rows-1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row+1].Length)
                {
                    for (int rowCur = row; rowCur < row+2; rowCur++)
                    {
                        for (int col = 0; col < jaggedArray[row].Length; col++)
                        {
                            jaggedArray[rowCur][col] = jaggedArray[rowCur][col] * 2;
                        }
                    }
                }
                else if (jaggedArray[row].Length != jaggedArray[row + 1].Length)
                {
                    for (int rowCur = row; rowCur < row + 2; rowCur++)
                    {
                        for (int col = 0; col < jaggedArray[rowCur].Length; col++)
                        {
                            jaggedArray[rowCur][col] = jaggedArray[rowCur][col] / 2;
                        }
                    }
                }
            }
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
            {
                if (input[0] == "Add" && input.Length == 4)
                {
                    if (ValidateInput(rows, jaggedArray, input))
                    {
                        jaggedArray[int.Parse(input[1])][int.Parse(input[2])] += int.Parse(input[3]);
                    }
                }
                else if (input[0] == "Subtract" && input.Length == 4)
                {
                    if (ValidateInput(rows, jaggedArray, input))
                    {
                        jaggedArray[int.Parse(input[1])][int.Parse(input[2])] -= int.Parse(input[3]);
                    }
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            PrintMatrix(jaggedArray, rows);
        }

        private static bool ValidateInput(int rows, int[][] jaggedArray, string[] input)
        {
            return int.Parse(input[1]) >= 0 && int.Parse(input[1]) < rows
                                && int.Parse(input[2]) >= 0 && int.Parse(input[2]) < jaggedArray[int.Parse(input[1])].Length;
        }
        private static void PrintMatrix(int[][] matrix, int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
