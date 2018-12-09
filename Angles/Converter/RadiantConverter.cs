using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles.Converter
{
    public class RadiantConverter : IAngleConverter
    {
        public double Convert(Angle angle)
        {
            if (angle is Radiant)
                return angle.Metric;
            else if (angle is Degree)
                return (Math.PI / 180) * angle.Metric;
            else
                throw new ArgumentException("Invalid anglular unit passed", "angle");
        }
    }
}
