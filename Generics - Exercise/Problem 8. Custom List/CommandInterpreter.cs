using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CommandInterpreter
{
    private CustomList<string> list;

    public CommandInterpreter()
    {
        this.list = new CustomList<string>();
    }

    public void InterpetCommand(string[] args)
    {
        var command = args[0];;

        switch (command)
        {
            case "Add":
                this.list.Add(args[1]);
                break;
            case "Remove":
                this.list.Remove(int.Parse(args[1]));
                break;
            case "Contains":
                Console.WriteLine(this.list.Contains(args[1]));
                break;
            case "Swap":
                this.list.Swap(int.Parse(args[1]), int.Parse(args[2]));
                break;
            case "Greater":
                Console.WriteLine(this.list.CountGreaterThan(args[1]));
                break;
            case "Max":
                Console.WriteLine(this.list.Max());
                break;
            case "Min":
                Console.WriteLine(this.list.Min());
                break;
            case "Print":
                foreach (var e in list.Elements)
                {
                    Console.WriteLine(e);
                }
                break;
            case "Sort":
                this.list = Sorter.Sort(list);
                break;
        }
    }
}
