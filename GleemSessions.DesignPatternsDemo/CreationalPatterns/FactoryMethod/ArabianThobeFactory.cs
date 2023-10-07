using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.FactoryMethod
{
    public class ArabianThobeFactory : IShirtFactory
    {
        public IShirt CreateShirt()
        {
            return new Thobe();
        }
    }
}
