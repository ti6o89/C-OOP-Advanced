using System;
using System.Collections.Generic;

namespace Problem_5.Comparing_Objects
{
    class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            int counter = 0;

            string inpuLine;
            while ((inpuLine = Console.ReadLine()) != "END")
            {
                var tokens = inpuLine.Split();
                Person person = new Person(tokens[0], int.Parse(tokens[1]), tokens[2]);
                people.Add(person);
            }

            int index = int.Parse(Console.ReadLine());

            for (int i = 0; i < people.Count; i++)
            {
                if (people[index - 1].CompareTo(people[i]) == 0)
                {
                    counter++;
                }               
            }
            if (counter > 1)
            {
                Console.WriteLine($"{counter} {people.Count - counter} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
