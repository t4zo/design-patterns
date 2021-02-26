using System;

namespace DesignPatterns.Observer
{
    internal class StatisticsDisplay : IObserver, IDisplayElement
    {
        public StatisticsDisplay(ISubject subject)
        {
            WeatherData = subject;
            WeatherData.RegisterObserver(this);
        }

        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public ISubject WeatherData { get; }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}