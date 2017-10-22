namespace _02BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    class BlackBoxIntegerTests
    {
        static void Main(string[] args)
        {
            Type classType = typeof(BlackBoxInt);
            BlackBoxInt myBlackBox = (BlackBoxInt)Activator.CreateInstance(classType ,true);

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                string[] tokens = inputLine.Split('_');
                var methodName = tokens[0];
                var value = int.Parse(tokens[1]);

                classType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic).Invoke(myBlackBox, new object[] { value });

                object innerStateValue = classType
                    .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                    .First()
                    .GetValue(myBlackBox);

                Console.WriteLine(innerStateValue);
            }
        }
    }
}
