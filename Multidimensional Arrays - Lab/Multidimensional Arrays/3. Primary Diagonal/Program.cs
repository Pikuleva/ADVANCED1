using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;
            int[,] matrix = new int[rows,cols];
            int sumFirst = 0;
        //    int sumSecond = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }

            }
            for (int row = 0; row < rows; row++)
            {
                sumFirst += matrix[row, row];
            }
            //for (int col = cols; col > 0; col--)
//            {
  //              sumSecond += matrix[rows-col, col];
    //        }
            Console.WriteLine(sumFirst);
      //      Console.WriteLine(sumSecond);
        }
    }
}
