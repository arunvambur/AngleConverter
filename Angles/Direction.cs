using System;
using System.Collections.Generic;
using System.Text;

namespace Angles
{
    /// <summary>
    /// Abstract class for Direction
    /// </summary>
    public abstract class Direction
    {

        /// <summary>
        /// Returns the quadrant of an angle
        /// </summary>
        /// <returns>Quadrant of an angle</returns>
        public Quadrant GetQuadrant(Angle angle)
        {
            double sin = angle.Sin();
            double cos = angle.Cos();
            double tan = angle.Tan();

            if (sin > 0 && cos > 0 && tan > 0)      //All three of them are positive in Quadrant I
                return Quadrant.NE;
            else if (sin > 0 && cos < 0 && tan < 0) //Sine only is positive in Quadrant II
                return Quadrant.NW;
            else if (sin < 0 && cos < 0 && tan > 0) //Tangent only is positive in Quadrant III
                return Quadrant.SW;
            else if (sin < 0 && cos > 0 && tan < 0) //Cosine only is positive in Quadrant IV
                return Quadrant.SE;

            throw new ArithmeticException("There is an issue while performing trignometric calculations");
        }

    }
}
