using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Command.Entities;

namespace DesignPatterns.Command.Commands
{
    class StereoOnCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
