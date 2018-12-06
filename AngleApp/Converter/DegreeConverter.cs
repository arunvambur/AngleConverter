using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleApp.Converter
{
    class DegreeConverter : IAngleConverter
    {
        public Angle Convert(Angle angle)
        {
            switch(angle.AngluarUnit)
            {
                case AngluarUnit.Degree:
                    return angle;

                case AngluarUnit.Radiant:
                    return new Degree();

                default:
                    return null;
            }

        }
    }
}
