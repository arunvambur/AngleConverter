using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Angles;
using Angles.Converter;

namespace AnglesExtended.Converter
{
    public class DegreeConverter : IAngleConverter
    {
        public double Convert(Angle angle)
        {
            if (angle is Gradian)
                return (180.0/200.0)* angle.Value;
            else
            {
                Angles.Converter.DegreeConverter dc = new Angles.Converter.DegreeConverter();
                return dc.Convert(angle);
            }
        }
    }
}
