using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.AbstractFactoryMethod
{
    public class NigerianClothFactory : IClothFactory
    {
        public IShirt CreateShirt()
        {
            return new NigerianShirt();
        }

        public ITrouser CreateTrouser()
        {
            return new NigerianTrouser();
        }
    }
}
