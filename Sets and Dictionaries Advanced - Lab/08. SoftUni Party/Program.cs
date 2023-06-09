using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> guests = new Dictionary<string, HashSet<string>>();
            guests.Add("VIP", new HashSet<string>());
            guests.Add("Regular", new HashSet<string>());
            string input = Console.ReadLine();
            string comes = string.Empty;

            while (input != "END")
            {
                
                if (input.Length == 8 && input[0]>47 && input[0]<58)
                {
                    guests["VIP"].Add(input);
                }
                else if (input.Length == 8)
                {
                    guests["Regular"].Add(input);
                }
                if (input == "PARTY")
                {
                    while (comes != "END")
                    {
                      
                        comes = Console.ReadLine();
                        if (comes == "END")
                        {
                            break;
                        }
                        if (guests["VIP"].Contains(comes))
                        {
                            guests["VIP"].Remove(comes);
                        }
                        if (guests["Regular"].Contains(comes))
                        {
                            guests["Regular"].Remove(comes);

                        }
                    }
                }
                if (comes == "END")
                {
                    break;
                }
                else
                {
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine(guests["VIP"].Count+guests["Regular"].Count);
            foreach (KeyValuePair<string, HashSet<string>> guest in guests)
            {
                foreach (var person in guest.Value)
                {
                    Console.WriteLine($"{person}");
                }
            }
        }
    }
}
