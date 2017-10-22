using System;
using System.Collections.Generic;

namespace Problem_6.Strategy_Pattern
{
    class StartUp
    {
        static void Main()
        {
            int numbersOfPeople = int.Parse(Console.ReadLine());
            var peopleByName = new SortedSet<Person>(new PersonNameComparator());
            var peopleByAge = new SortedSet<Person>(new PersonAgeComparator());

            for (int i = 0; i < numbersOfPeople; i++)
            {
                var personTokens = Console.ReadLine().Split();

                var person = new Person(personTokens[0], int.Parse(personTokens[1]));
                peopleByAge.Add(person);
                peopleByName.Add(person);
            }

            foreach (var person in peopleByName)
            {
                Console.WriteLine(person);
            }
            foreach (var person in peopleByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
