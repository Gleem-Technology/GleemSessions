using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.AbstractFactoryMethod
{
    public class NigerianTrouser : ITrouser
    {
        public void Describe()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Top quality, e no fit tear. Oga try am see, na your size...\nyou see! e fit you... 20 thousand...\n2 5 last...");
            Console.ResetColor();
        }
    }
}
