using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Command.Entities;

namespace DesignPatterns.Command.Commands
{
    class GarageDoorDownCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.Up();
        }
    }
}
