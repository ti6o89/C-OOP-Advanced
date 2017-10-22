using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1.Generic_Box
{
    class StartUp
    {
        static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            List<Box<double>> ListOfBoxes = new List<Box<double>>();

            for (int i = 0; i < numberOfElements; i++)
            {
                Box<double> boxDouble = new Box<double>(double.Parse(Console.ReadLine()));

                ListOfBoxes.Add(boxDouble);
            }

            var element = double.Parse(Console.ReadLine());

            var result = GetGreaterElementCount(ListOfBoxes, element);

            Console.WriteLine(result);
        }

        private static int GetGreaterElementCount<T>(List<Box<T>> listOfBoxes, T element)
            where T : IComparable<T>
        {
            return listOfBoxes.Count(b => b.Data.CompareTo(element) > 0);
        }
    }
}
