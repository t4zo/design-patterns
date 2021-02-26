using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Command.Entities;

namespace DesignPatterns.Command.Commands
{
    class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}
