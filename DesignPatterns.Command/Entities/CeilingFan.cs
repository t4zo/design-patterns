using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Entities
{
    class CeilingFan
    {
        private readonly string _location;
        public Speed speed { get; set; }

        public CeilingFan(string location)
        {
            _location = location;
            speed = Speed.Off;
        }

        public void High()
        {
            speed = Speed.High;
        }

        public void Medium()
        {
            speed = Speed.Medium;
        }

        public void Low()
        {
            speed = Speed.Low;
        }

        public void Off()
        {
            speed = Speed.Off;
        }
    }

    public enum Speed
    {
        Off,
        Low,
        Medium,
        High
    }
}
