using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Entities
{
    class Stereo
    {
        private readonly string _name;

        public Stereo(string name)
        {
            _name = name;
        }

        public void On()
        {
            Console.WriteLine($"{_name} Stereo is On");
        }

        public void Off()
        {
            Console.WriteLine($"{_name} is Off");
        }

        public void SetCd()
        {
            Console.WriteLine($"{_name} Set Cd");
        }

        public void SetDvd()
        {
            Console.WriteLine($"{_name} Set Dvd");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{_name} Set Radio");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"{_name} Volume set to {volume}");
        }
    }
}
