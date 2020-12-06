
using System;

namespace DesignPatterns.Observer
{
    internal class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public ISubject WeatherData { get; private set; }

        public CurrentConditionsDisplay(ISubject subject)
        {
            WeatherData = subject;
            WeatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {Temperature}F degrees and {Humidity}% humidity");
            Console.WriteLine($"Heat Index is {HeatIndex()}");
        }

        public float HeatIndex()
        {
            return (float)((16.923 + (0.185212 * Temperature) + (5.37941 * Humidity) - (0.100254 * Temperature * Humidity) +
            (0.00941695 * (Temperature * Temperature)) + (0.00728898 * (Humidity * Humidity)) +
            (0.000345372 * (Temperature * Temperature * Humidity)) - (0.000814971 * (Temperature * Humidity * Humidity)) +
            (0.0000102102 * (Temperature * Temperature * Humidity * Humidity)) - (0.000038646 * (Temperature * Temperature * Temperature)) + (0.0000291583 *
            (Humidity * Humidity * Humidity)) + (0.00000142721 * (Temperature * Temperature * Temperature * Humidity)) +
            (0.000000197483 * (Temperature * Humidity * Humidity * Humidity)) - (0.0000000218429 * (Temperature * Temperature * Temperature * Humidity * Humidity)) +
            0.000000000843296 * (Temperature * Temperature * Humidity * Humidity * Humidity)) -
            (0.0000000000481975 * (Temperature * Temperature * Temperature * Humidity * Humidity * Humidity)));
        }
    }
}
