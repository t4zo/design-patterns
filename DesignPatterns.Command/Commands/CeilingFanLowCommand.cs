using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Command.Entities;

namespace DesignPatterns.Command.Commands
{
    class CeilingFanLowCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        public Speed prevSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = _ceilingFan.speed;
            _ceilingFan.Low();
        }

        public void Undo()
        {
            if (prevSpeed == Speed.High)
            {
                _ceilingFan.High();
            }
            else if (prevSpeed == Speed.Medium)
            {
                _ceilingFan.Medium();
            }
            else if (prevSpeed == Speed.Low)
            {
                _ceilingFan.Low();
            }
            else if (prevSpeed == Speed.Off)
            {
                _ceilingFan.Off();
            }
        }
    }
}
