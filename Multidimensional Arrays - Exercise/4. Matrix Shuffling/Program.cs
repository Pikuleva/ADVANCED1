using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = ReadMatrix();

            string command = Console.ReadLine();
            
         
            while (command != "END")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0] != "swap" && input.Length<5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else if(input[0] == "swap"&&input.Length==5)
                {
                    int oldRowIndex = int.Parse(input[1]);
                    int oldColIndex = int.Parse(input[2]);
                    int newRowIndex = int.Parse(input[3]);
                    int newColIndex = int.Parse(input[4]);

                    if (oldRowIndex > matrix.GetLength(0)-1
                        || oldRowIndex < 0
                        || oldColIndex > matrix.GetLength(1)-1
                        || oldColIndex < 0
                        || newRowIndex > matrix.GetLength(0)-1
                        || newRowIndex < 0
                        || newColIndex > matrix.GetLength(1)-1
                        || newColIndex < 0 || input[0] != "swap"
                        || input.Length != 5)
                    {
                        Console.WriteLine("Invalid input!");

                    }
                    else if (input[0] == "swap" && input.Length == 5)
                    {
                        string oldNum = matrix[oldRowIndex, oldColIndex];
                        string newNum = matrix[newRowIndex, newColIndex];
                        matrix[oldRowIndex, oldColIndex] = newNum;
                        matrix[newRowIndex, newColIndex] = oldNum;
                        PrintMatrix(matrix);
                    }
                }

               

                command= Console.ReadLine();
           


            }
            
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static string[,] ReadMatrix()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
