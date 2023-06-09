using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons persons = new Persons();

            int n = int.Parse(Console.ReadLine());

            List<Persons> people = new List<Persons>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Persons() { Name = input[0], Age = int.Parse(input[1])});
            }
            string filterType = Console.ReadLine();
            int value = int.Parse(Console.ReadLine());
            string formateType = Console.ReadLine();

            Func<Persons, bool> filtered = FilterByAge(filterType, value);



            people = people.Where(filtered).ToList();
            Action<Persons> printer = GetPrint(formateType);

            foreach (var person in people)
            {
                printer(person);
            }

            Func<Persons, bool> FilterByAge(string filterType, int value)
            {
                if (filterType == "younger")
                {
                    return persons => persons.Age <= value;
                }
                else
                {
                    return persons => persons.Age >= value;
                }
                return null;
            }

            Action<Persons> GetPrint(string formatType)
            {
                switch (formateType)
                {
                    case "name age": 
                            return p => Console.WriteLine($"{p.Name} - {p.Age}");
                    case "name": 
                             return p => Console.WriteLine($"{p.Name}");
                    case "age": 
                             return p => Console.WriteLine($"{p.Age}");
                      default:
                            return null;


                }

            }
        }

        

    }
    public class Persons
    {
        public string Name;
        public int Age;
    }
}
