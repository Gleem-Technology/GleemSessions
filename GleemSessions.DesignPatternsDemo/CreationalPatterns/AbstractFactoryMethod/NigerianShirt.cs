using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.AbstractFactoryMethod
{
    public class NigerianShirt : IShirt
    {
        public void Describe()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You no fit see this shirt anywhere o, bros e get kwality.");
            Console.ResetColor();
        }
    }
}
