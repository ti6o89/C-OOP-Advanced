using System;

namespace Problem_11.Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split();
            var name = $"{inputLine[0]} {inputLine[1]}";
            var address = inputLine[2];
            Console.WriteLine(new Tuple<string, string>(name, address));

            inputLine = Console.ReadLine().Split();
            var firstName = inputLine[0];
            var litersOfBeer = int.Parse(inputLine[1]);
            Console.WriteLine(new Tuple<string, int>(firstName, litersOfBeer));

            inputLine = Console.ReadLine().Split();
            var integer = int.Parse(inputLine[0]);
            var doubleNumber = double.Parse(inputLine[1]);
            Console.WriteLine(new Tuple<int, double>(integer, doubleNumber));
        }
    }
}
