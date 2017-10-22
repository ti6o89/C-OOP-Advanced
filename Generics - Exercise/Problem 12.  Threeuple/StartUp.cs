using System;

namespace Problem_12.Threeuple
{
    public class StartUp
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split();
            var name = $"{inputLine[0]} {inputLine[1]}";
            var address = inputLine[2];
            var town = inputLine[3];
            Console.WriteLine(new Threeuple<string, string, string>(name, address, town));


            inputLine = Console.ReadLine().Split();
            name = inputLine[0];
            var litersOfBeer = int.Parse(inputLine[1]);
            bool isDrunk = inputLine[2] == "drunk";
            Console.WriteLine(new Threeuple<string, int, bool>(name, litersOfBeer, isDrunk));

            inputLine = Console.ReadLine().Split();
            name = inputLine[0];
            var balance = double.Parse(inputLine[1]);
            var bankName = inputLine[2];
            Console.WriteLine(new Threeuple<string, double, string>(name, balance, bankName));
        }
    }
}
