using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle()
        {
        }

        public Circle(Circle circle) : base(circle)
        {
            Radius = circle.Radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}
