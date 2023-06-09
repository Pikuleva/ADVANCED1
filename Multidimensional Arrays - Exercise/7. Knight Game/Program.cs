using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            int[,] matrix = new int[rows, cols];
            
            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    if (input[col] == 'K')
                    {
                        matrix[row, col] = 1;
                    }
                    else if (input[col] == 'O')
                    {
                        matrix[row, col] = 0;
                    }
                }
            }
            ChekCombination(rows, cols, matrix, count);              
        }  

        private static void ChekCombination(int rows, int cols, int[,] matrix, int count)
        {
            for (int row = rows-1; row >= 0; row--)
            {
                for (int col = cols-1; col >= 0; col--)
                {
                    if (matrix[row, col] > 0)
                    {
                        if (row < rows - 1 && col < cols - 2)
                        {
                            if (matrix[row + 1, col + 2] > 0)
                            {
                                matrix[row + 1, col + 2] = 0;
                                count++;
                            }
                        }
                        if (row < rows - 2 && col < cols - 1)
                        {
                            if (matrix[row + 2, col + 1] > 0)
                            {
                                matrix[row + 2, col + 1] =0;
                                count++;
                            }
                        }

                        if (row > 0 && col > 1)
                        {
                            if (matrix[row - 1, col - 2] > 0)
                            {
                                matrix[row - 1, col - 2] = 0;
                                count++;
                            }
                        }
                        if (row > 1 && col > 0)
                        {
                            if (matrix[row - 2, col - 1] > 0)
                            {
                                matrix[row - 2, col - 1] = 0;
                                count++;
                            }
                        }
                        if (row < rows - 1 && col > 1)
                        {
                            if (matrix[row + 1, col - 2] > 0)
                            {
                                matrix[row + 1, col - 2] = 0 ;
                                count++;
                            }
                        }
                        if (row < rows - 2 && col < 0)
                        {
                            if (matrix[row + 2, col - 1] > 0)
                            {
                                matrix[row + 2, col - 1] = 0;
                                count++;
                            }
                        }
                        if (row > 0 && col < cols - 2)
                        {
                            if (matrix[row - 1, col + 2] > 0)
                            {
                                matrix[row - 1, col + 2] = 0;
                                count++;
                            }
                        }
                        if (row > 1 && col < cols - 1)
                        {
                            if (matrix[row - 2, col + 1] > 0)
                            {
                                matrix[row - 2, col + 1] = 0;
                                count++;
                            }
                        }

                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
