using System;
using System.Linq;

namespace Problem_1.ListyIterator
{
    class StartUp
    {
        static void Main()
        {
            ListyIterator<string> list = null;

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var args = inputLine.Split();
                var command = args[0];

                try
                {
                    switch (command)
                    {
                        case "Create":
                            list = new ListyIterator<string>(args.Skip(1));
                            break;
                        case "Move":
                            Console.WriteLine(list.Move());
                            break;
                        case "Print":
                            list.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(list.HasNext());
                            break;
                        case "PrintAll":
                            list.PrintAll();
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
