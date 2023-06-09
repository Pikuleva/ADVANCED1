using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();               
            }
            string[] input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                if (row >= rows || row<0)
                {
                    Console.WriteLine("Invalid coordinates");
                    
                }
                else if (col > jaggedArray[row].Length || col<0)
                {
                    Console.WriteLine("Invalid coordinates");
                 
                }
                else if (input[0] == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (input[0] == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }
                input = Console.ReadLine().Split();
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
