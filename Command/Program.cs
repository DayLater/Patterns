using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Commands;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Invoker();
            invoker.SetCommand("1", new CreateCommand());
            invoker.SetCommand("2", new ComplexCommand(new ImportantBusinessClass()));
            invoker.SetCommand("3", new ChangeItemCommand(new Item(){Name = "ChangedItem", State = false}));
            string inputToQuit;
            do
            {
                Console.WriteLine("Choose command to execute");
                invoker.PrintAllCommands();
                var input = Console.ReadLine();
                if (!invoker.TryActivateCommand(input))
                    Console.WriteLine("Unknown command");

                Console.WriteLine("If you want to undo last command enter undo");
                var undo = Console.ReadLine();
                if (undo == "undo")
                    invoker.UndoLastCommand();

                Console.WriteLine("Do you wanna quit? y/n");
                inputToQuit = Console.ReadLine();
            } while (inputToQuit == "n");
            Console.WriteLine("GoodBye");
        }
    }
}
