using DefiningClasses;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            int count = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] persons = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new(persons[0], int.Parse(persons[1]));
                list.Add(person);

            }
           
            List<Person> sorter = list.Where(x=>x.Age>30).OrderBy(x=>x.Name).ToList();
            foreach (var name in sorter)
            {
                Console.WriteLine($"{name.Name} - {name.Age}");
            }
        }
    }
}