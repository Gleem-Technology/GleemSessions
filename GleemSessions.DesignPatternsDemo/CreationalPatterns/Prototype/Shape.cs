﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GleemSessions.DesignPatternsDemo.CreationalPatterns.Prototype
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Shape()
        {
        }

        public Shape(Shape shape)
        {
            X = shape.X;
            Y = shape.Y;
        }

        public abstract Shape Clone();
    }
}
