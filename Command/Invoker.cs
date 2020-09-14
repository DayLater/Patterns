using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Command.Commands;

namespace Command
{
    public class Invoker
    {
        private readonly Dictionary<string, ICommand> commands;
        private readonly Stack<ICommand> executeCommands;

        public Invoker()
        {
            commands = new Dictionary<string, ICommand>();
            executeCommands = new Stack<ICommand>();
        }

        public bool TryActivateCommand(string commandId)
        {
            if (commands.ContainsKey(commandId))
            {
                var command = commands[commandId];
                executeCommands.Push(command);
                command.Execute();
                return true;
            }
            return false;
        }

        public void PrintAllCommands()
        {
            foreach (var command in commands)
            {
                Console.WriteLine($"Enter {command.Key} to activate command: {command.Value.Description}");
            }
        }

        public void UndoLastCommand()
        {
            if (executeCommands.Count == 0)
                Console.WriteLine("There is no executed commands");
            else executeCommands.Pop().Undo();
        }

        public void SetCommand(string commandId, ICommand command)
        {
            commands[commandId] = command;
        }
    }
}
