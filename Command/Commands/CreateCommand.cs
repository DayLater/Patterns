using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Command.Commands
{
    public class CreateCommand: ICommand
    {
        private Stack<Item> items;
        private static readonly Random random = new Random();

        public string Description => "Create item";

        public CreateCommand()
        {
            items = new Stack<Item>();
        }
        public void Execute()
        {
            items.Push(new Item(){State = true, Name = $"{new string('a', random.Next(10))}"});
            Console.WriteLine("Something was created");
        }

        public void Undo()
        {
            var item = items.Pop();
            Console.WriteLine($"Deleted created item with name {item.Name}");
        }
    }
}
