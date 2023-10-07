using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns
{
    public class ThreadSafeSingleton
    {
        private static object _lock = new object();

        #region Singleton
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
