using System;
using System.Collections.Generic;
using System.Text;

namespace Angles
{
    public class CompassDirection : Direction
    {
        public CompassDirection()
        {

        }

        public static implicit operator CompassDirection(MathematicalDirection direction)
        {
            return new CompassDirection();
        }
    }
}
