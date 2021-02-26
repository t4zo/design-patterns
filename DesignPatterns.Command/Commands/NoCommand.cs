using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Entities
{
    class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Command");
        }

        public void Undo()
        {
            Console.WriteLine("No Command");
        }
    }
}
