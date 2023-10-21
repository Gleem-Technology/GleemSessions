using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.AbstractFactoryMethod
{
    public class IndianShirt : IShirt
    {
        public void Describe()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("यह भारत में हमारी सबसे अच्छी शर्ट है।");
            Console.ResetColor();
        }
    }
}
