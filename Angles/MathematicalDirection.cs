using System;
using System.Collections.Generic;
using System.Text;

namespace Angles
{
    public class MathematicalDirection : Direction
    {
        public MathematicalDirection(Angle _angle) : base(_angle)
        {
            
        }

        public override Quadrant GetQuadrant()
        {
            throw new NotImplementedException();
        }

        public static implicit operator MathematicalDirection(CompassDirection direction)
        {
            return new MathematicalDirection(direction.Angle);
        }
    }
}
