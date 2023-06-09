using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> song = new Queue<string>(songs);

            while (song.Any())
            {
               
                string[] input = Console.ReadLine().Split();
               
                if (input[0] == "Play" && song.Count>0)
                {
                    song.Dequeue();              
                }
                else if (input[0] == "Add")
                {
                    string songAdd = string.Join(" ", input.Skip(1));
                    if (song.Contains(songAdd))
                    {
                        Console.WriteLine($"{songAdd} is already contained!");
                    }
                    else
                    {
                        song.Enqueue(songAdd);
                    }
                }
                else if (input[0] == "Show" && song.Count>0)
                {
                    Console.WriteLine(string.Join(", ", song));
                }

            }
            if (song.Count == 0)
            {
                Console.WriteLine("No more songs!");

               
            }
        }
    }
}
