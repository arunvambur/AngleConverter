using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Angles.Converter;

namespace Angles
{
    /// <summary>
    /// Implementation for radiant unit
    /// </summary>
    public class Radiant : Angle
    {
        /// <summary>
        /// Default angle converter
        /// </summary>
        private void Default()
        {
            AngleConverter = new RadiantConverter();
        }

        public Radiant()
        {
            Default();
        }

        /// <summary>
        /// Initializes Radiant type
        /// </summary>
        /// <param name="rad">Angle in radiant unit</param>
        public Radiant(double rad)
        {
            Default();
            value = rad;
            Validate();
        }

        /// <summary>
        /// Initializes Radiant type
        /// </summary>
        /// <param name="rad">Angle in radiant unit</param>
        /// <param name="angleConverter">Radiant angle converter</param>
        public Radiant(double rad, IAngleConverter angleConverter)
        {
            value = rad;
            AngleConverter = angleConverter;
            Validate();
        }

        /// <summary>
        /// Cast Degree type to Radiant type
        /// </summary>
        /// <param name="angle">Degree</param>
        public static implicit operator Radiant(Degree angle)
        {
            RadiantConverter rc = new RadiantConverter();
            return new Radiant(rc.Convert(angle));
        }

        protected override Angle Add(Angle angle)
        {
            return new Radiant(this.value + AngleConverter.Convert(angle));
        }

        protected override Angle Sub(Angle angle)
        {
            return new Radiant(this.value - AngleConverter.Convert(angle));
        }

        protected override Angle Mul(double mul)
        {
            return new Radiant(this.value * mul);
        }

        protected override Angle Div(double div)
        {
            return new Radiant(this.value / div );
        }

        protected override Angle Mod(double mod)
        {
            return new Radiant(this.value % mod);
        }

        protected override bool Lessthan(Angle angle)
        {
            return this.value < AngleConverter.Convert(angle);
        }

        protected override bool GreaterThan(Angle angle)
        {
            return this.value > AngleConverter.Convert(angle);
        }

        protected override bool Equal(Angle angle)
        {
            return this.value == AngleConverter.Convert(angle);
        }

        protected override bool NotEqual(Angle angle)
        {
            return this.value != AngleConverter.Convert(angle);
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
            if (value < 0 || value > 6.28)
                new AngleOutOfRangeException("The degree is out of range", Value, 0, 6.28);
        }
    }
}
