using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.Prototype
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }

        public Rectangle(Rectangle rectangle) : base(rectangle)
        {
            Width = rectangle.Width;
            Height = rectangle.Height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}
