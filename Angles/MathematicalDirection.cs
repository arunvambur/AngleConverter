using System;
using System.Collections.Generic;
using System.Text;

namespace Angles
{
    public class MathematicalDirection : Direction
    {
        public MathematicalDirection() 
        {
            
        }

        public static implicit operator MathematicalDirection(CompassDirection direction)
        {
            return new MathematicalDirection();
        }
    }
}
