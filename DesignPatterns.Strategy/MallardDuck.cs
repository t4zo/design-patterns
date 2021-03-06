﻿using System;
using DesignPatterns.Strategy.Interfaces.Fly;
using DesignPatterns.Strategy.Interfaces.Quack;

namespace DesignPatterns.Strategy
{
    internal class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyNoWay(), new Quack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Displaying...");
        }
    }
}