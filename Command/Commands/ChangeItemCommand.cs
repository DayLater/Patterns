using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class ChangeItemCommand: ICommand
    {
        private Item item;

        public ChangeItemCommand(Item item)
        {
            this.item = item;
        }

        public string Description => "Change item command";

        public void Execute()
        {
            item.State = !item.State; 
            Console.WriteLine($"State of {item.Name} was changed to {item.State}");
        }

        public void Undo()
        {
            item.State = !item.State;
            Console.WriteLine($"State of {item.Name} was changed to {item.State}");
        }
    }
}
