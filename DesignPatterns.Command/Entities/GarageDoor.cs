using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Entities
{
    class GarageDoor
    {
        private readonly string _name;

        public GarageDoor(string name)
        {
            _name = name;
        }

        public void Up()
        {
            Console.WriteLine($"{_name} Door is open");
        }

        public void Down()
        {
            Console.WriteLine($"{_name} Door is down");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} Door stopped");
        }

        public void LightOn()
        {
            Console.WriteLine($"{_name} Light is on");
        }

        public void LightOff()
        {
            Console.WriteLine($"{_name} Light is off");
        }
    }
}
