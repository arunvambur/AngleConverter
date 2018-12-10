using System;
using System.Collections.Generic;
using System.Text;

namespace Angles
{
    public class CompassDirection : Direction
    {
        public CompassDirection(Angle _angle) : base(_angle)
        {

        }

        public override Quadrant GetQuadrant()
        {
            throw new NotImplementedException();
        }

        public static implicit operator CompassDirection(MathematicalDirection direction)
        {
            return new CompassDirection(direction.Angle);
        }
    }
}
