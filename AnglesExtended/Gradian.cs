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
    /// <summary>
    /// Concrete implementation of Gradian converter
    /// </summary>
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
            value = grad;
        }

        public Gradian(double grad, IAngleConverter angleConverter)
        {
            value = grad;
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
            return new Degree(this.Value + AngleConverter.Convert(angle));
        }

        protected override Angle Sub(Angle angle)
        {
            throw new NotImplementedException();
        }


        protected override bool Lessthan(Angle angle)
        {
            throw new NotImplementedException();
        }

        protected override bool GreaterThan(Angle angle)
        {
            throw new NotImplementedException();
        }

        protected override bool Equal(Angle angle)
        {
            throw new NotImplementedException();
        }

        protected override bool NotEqual(Angle angle)
        {
            throw new NotImplementedException();
        }

        protected override double Sin()
        {
            throw new NotImplementedException();
        }

        protected override double Cos()
        {
            throw new NotImplementedException();
        }

        protected override double Tan()
        {
            throw new NotImplementedException();
        }

        protected override double ArcSin()
        {
            throw new NotImplementedException();
        }

        protected override double ArcCos()
        {
            throw new NotImplementedException();
        }

        protected override double ArcTan()
        {
            throw new NotImplementedException();
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        protected override Angle Mul(double mul)
        {
            throw new NotImplementedException();
        }

        protected override Angle Div(double div)
        {
            throw new NotImplementedException();
        }

        protected override Angle Mod(double mod)
        {
            throw new NotImplementedException();
        }
    }
}
