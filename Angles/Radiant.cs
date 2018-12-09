using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Angles.Converter;

namespace Angles
{
    public class Radiant : Angle
    {
        private void Default()
        {
            AngleConverter = new RadiantConverter();
        }

        public Radiant()
        {
            Default();
        }

        public Radiant(double _rad)
        {
            Default();
            angle = _rad;
        }

        public Radiant(double _rad, IAngleConverter angleConverter)
        {
            angle = _rad;
            AngleConverter = angleConverter;
        }

        public static implicit operator Radiant(Degree angle)
        {
            RadiantConverter rc = new RadiantConverter();
            return new Radiant(rc.Convert(angle));
        }

        protected override Angle Add(Angle angle)
        {
            return new Radiant(this.angle + AngleConverter.Convert(angle));
        }

    }
}
