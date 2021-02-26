namespace DesignPatterns.Observer
{
    internal interface ISubject
    {
        public float Temperature { get; }
        public float Humidity { get; }
        public float Pressure { get; }

        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}