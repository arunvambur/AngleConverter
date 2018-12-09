using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Angles;
using Angles.Converter;

namespace AnglesExtended.Converter
{
    public class GradianConverter : IAngleConverter
    {
        public double Convert(Angle angle)
        {
            if (angle is Gradian)
                return angle.Metric;
            else if (angle is Degree)
                return (200/180) * angle.Metric;
            else if (angle is Radiant)
                return (200/Math.PI) * angle.Metric;
            else
                throw new ArgumentException("Invalid anglular unit passed", "angle");

        }
    }
}
