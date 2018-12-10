using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles.Converter
{
    /// <summary>
    /// Concrete implementation of Radiant converter
    /// </summary>
    public class RadiantConverter : IAngleConverter
    {
        public double Convert(Angle angle)
        {
            if (angle is Radiant)
                return angle.Value;
            else if (angle is Degree)
                return (Math.PI / 180) * angle.Value;
            else
                throw new ArgumentException("Invalid anglular unit passed", "angle");
        }
    }
}
