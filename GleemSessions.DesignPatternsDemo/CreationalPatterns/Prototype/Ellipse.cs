using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.Prototype
{
    public class Ellipse : Circle
    {
        public int Rx { get; set; }
        public int Ry { get; set; }

        public Ellipse() { }
        public Ellipse(Ellipse ellipse) : base(ellipse) 
        {
            Rx = ellipse.Rx;
            Ry = ellipse.Ry;
        }

        public override Shape Clone()
        {
            return new Ellipse(this);
        }
    }
}
