using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AnglesExtended.Converter;

namespace AnglesExtended
{
    public class Radiant : Angles.Radiant
    {
        private void Default()
        {
            AngleConverter = new RadiantConverter();
        }

        public Radiant()
        {
            Default();
        }

        public Radiant(double _deg)
        {
            Default();
            angle = _deg;
        }

        public Radiant(double _deg, Angles.Converter.IAngleConverter angleConverter)
        {
            angle = _deg;
            AngleConverter = angleConverter;
        }

        public static implicit operator Radiant(Gradian angle)
        {
            RadiantConverter dc = new RadiantConverter();
            return new Radiant(dc.Convert(angle));
        }

        public static implicit operator Radiant(Angles.Degree angle)
        {
            RadiantConverter dc = new RadiantConverter();
            return new Radiant(dc.Convert(angle));
        }
    }
}
