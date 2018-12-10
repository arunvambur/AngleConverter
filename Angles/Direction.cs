using System;
using System.Collections.Generic;
using System.Text;

namespace Angles
{
    public abstract class Direction
    {
        Angle angle;

        public Angle Angle { get { return angle; } set { angle = value; } }

        public Direction(Angle _angle)
        {
            angle = _angle;
        }


        public abstract Quadrant GetQuadrant();

    }
}
