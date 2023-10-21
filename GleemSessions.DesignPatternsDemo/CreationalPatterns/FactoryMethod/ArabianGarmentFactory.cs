using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.FactoryMethod
{
    public class ArabianGarmentFactory : IGarmentFactory
    {
        public IGarment CreateGarment()
        {
            return new Thobe();
        }
    }
}
