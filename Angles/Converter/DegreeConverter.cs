using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles.Converter
{
    public class DegreeConverter : IAngleConverter
    {
        public double Convert(Angle angle)
        {
            if (angle is Degree)
                return angle.Metric;
            else if (angle is Radiant)
                return (180 / Math.PI) * angle.Metric;
            else
                throw new ArgumentException("Invalid anglular unit passed", "angle");

        }
    }
}
