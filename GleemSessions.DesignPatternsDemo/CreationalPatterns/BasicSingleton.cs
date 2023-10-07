using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns
{
    public class BasicSingleton
    {
        public string Value { get; set; } = "Hello";

        #region Singleton
        private static BasicSingleton _instance;
        private BasicSingleton() { }
        public static BasicSingleton GetInstance()
        {
            if (_instance is null)
            {
                _instance = new BasicSingleton();
            }

            return _instance;
        }
        #endregion
    }
}
