using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleApp.Converter
{
    class RadiantConverter : IAngleConverter
    {
        public Angle Convert(Angle angle)
        {
            switch (angle.AngluarUnit)
            {
                case AngluarUnit.Degree:
                    return new Radiant();

                case AngluarUnit.Radiant:
                    return angle;

                default:
                    return null;
            }
        }
    }
}
