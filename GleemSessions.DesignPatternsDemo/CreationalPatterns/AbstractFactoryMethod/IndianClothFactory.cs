using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.AbstractFactoryMethod
{
    public class IndianClothFactory : IClothFactory
    {
        public IShirt CreateShirt()
        {
            return new IndianShirt();
        }

        public ITrouser CreateTrouser()
        {
            return new IndianTrouser();
        }
    }
}
