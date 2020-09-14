using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class ComplexCommand: ICommand
    {
        private readonly ImportantBusinessClass superClass;

        public ComplexCommand(ImportantBusinessClass superClass)
        {
            this.superClass = superClass;
        }

        public string Description => "Complex command";

        public void Execute()
        {
            superClass.ImportantMethod();
            superClass.SuperImportantActivity();
            
        }

        public void Undo()
        {
            Console.WriteLine("Undo complex activity");
        }
    }
}
