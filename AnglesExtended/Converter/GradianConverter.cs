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
                return angle.Value;
            else if (angle is Degree || angle is Angles.Degree)
                return (200.0/180.0) * angle.Value;
            else if (angle is Radiant || angle is Angles.Radiant)
                return (200.0/Math.PI) * angle.Value;
            else
                throw new ArgumentException("Invalid anglular unit passed", "angle");

        }
    }
}
