namespace DesignPatterns.Singleton
{
    internal class Singleton
    {
        private static readonly object _syncLock = new object();

        private Singleton()
        {
        }

        private static Singleton _instance { get; set; }

        public static Singleton GetInstance()
        {
            lock (_syncLock)
            {
                if (_instance is null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }
}