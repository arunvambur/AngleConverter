using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Angles;
using Angles.Converter;

namespace AnglesExtended.Converter
{
    public class RadiantConverter : IAngleConverter
    {
        public double Convert(Angle angle)
        {
            if (angle is Gradian)
                return (Math.PI/200.0) * angle.Value;
            else
            {
                Angles.Converter.RadiantConverter rc = new Angles.Converter.RadiantConverter();
                return rc.Convert(angle);
            }
        }
    }
}
