
using System;

namespace DesignPatterns.Observer
{
    internal class ForecastDisplay : IObserver, IDisplayElement
    {
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public ISubject WeatherData { get; private set; }

        public ForecastDisplay(ISubject subject)
        {
            WeatherData = subject;
            WeatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
