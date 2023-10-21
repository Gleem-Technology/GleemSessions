using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.AbstractFactoryMethod
{
    public class IndianTrouser : ITrouser
    {
        public void Describe()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("आओ और मुझसे सबसे सस्ता पतलून खरीदो भाई।");
            Console.ResetColor();
        }
    }
}
