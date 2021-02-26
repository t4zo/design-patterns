using System;

namespace DesignPatterns.Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            Console.WriteLine($"Equals: {singleton1.Equals(singleton2)}");
            Console.WriteLine($"HashCode - Singlenton 1: {singleton1.GetHashCode()}");
            Console.WriteLine($"HashCode - Singlenton 2: {singleton2.GetHashCode()}");
        }
    }
}