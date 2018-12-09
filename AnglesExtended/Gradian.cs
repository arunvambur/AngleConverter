using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Angles;
using Angles.Converter;
using AnglesExtended.Converter;

namespace AnglesExtended
{
    public class Gradian : Angle
    {
        private void Default()
        {
            AngleConverter = new GradianConverter();
        }

        public Gradian()
        {
            Default();
        }

        public Gradian(double grad)
        {
            Default();
            angle = grad;
        }

        public Gradian(double grad, IAngleConverter angleConverter)
        {
            angle = grad;
            AngleConverter = angleConverter;
        }

        public static implicit operator Gradian(Angles.Radiant angle)
        {
            GradianConverter gc = new GradianConverter();
            return new Radiant(gc.Convert(angle));
        }

        public static implicit operator Gradian(Angles.Degree angle)
        {
            GradianConverter gc = new GradianConverter();
            return new Radiant(gc.Convert(angle));
        }

        protected override Angle Add(Angle angle)
        {
            throw new NotImplementedException();
        }
    }
}
