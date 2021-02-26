using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DesignPatterns.Command.Entities;

namespace DesignPatterns.Command
{
    class SimpleRemoteControl
    {
        private IList<ICommand> _onCommands { get; set; }
        private IList<ICommand> _offCommands { get; set; }

        public SimpleRemoteControl()
        {
            _onCommands = new List<ICommand>(7);
            _offCommands = new List<ICommand>(7);

            ICommand noCommand = new NoCommand();

            for (int i = 0; i < 7; i++)
            {
                _onCommands.Add(noCommand);
                _offCommands.Add(noCommand);
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("------------- Remote Control -------------\n");
            
            for (int i = 0; i < _onCommands.Count; i++)
            {
                stringBuilder.Append($"[Slot {i}] {_onCommands[i].GetType().Name} | {_offCommands[i].GetType().Name}\n");
            }

            return stringBuilder.ToString();
        }
    }
}
