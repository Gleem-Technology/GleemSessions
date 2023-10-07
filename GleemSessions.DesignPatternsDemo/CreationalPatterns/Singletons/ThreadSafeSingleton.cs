namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.Singletons
{
    public class ThreadSafeSingleton
    {
        public string Value { get; set; } = "Hello";

        #region Singleton
        private static object _lock = new();
        private static ThreadSafeSingleton _instance;
        private ThreadSafeSingleton() { }
        public static ThreadSafeSingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }
            }

            return _instance;
        }
        #endregion
    }
}
