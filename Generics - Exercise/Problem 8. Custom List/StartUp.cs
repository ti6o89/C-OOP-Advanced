using System;
using System.Linq;

namespace Problem_8.Custom_List
{
    class StartUp
    {
        static void Main()
        {
            CommandInterpreter cm = new CommandInterpreter();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var tokens = inputLine.Split().ToArray();
                cm.InterpetCommand(tokens);
            }
        }
    }
}
