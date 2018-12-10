using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles.Converter
{
    /// <summary>
    /// Concrete implementation of Degree converter
    /// </summary>
    public class DegreeConverter : IAngleConverter
    {
        public double Convert(Angle angle)
        {
            if (angle is Degree)
                return angle.Value;
            else if (angle is Radiant)
                return (180 / Math.PI) * angle.Value;
            else
                throw new ArgumentException("Invalid anglular unit passed", "angle");

        }
    }
}
