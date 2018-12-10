using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Angles.Converter;

namespace Angles
{
    /// <summary>
    /// Implementation for degree unit
    /// </summary>
    public class Degree : Angle
    {
        /// <summary>
        /// Default Degree converter
        /// </summary>
        private void Default()
        {
            AngleConverter = new DegreeConverter();
        }

        /// <summary>
        /// Initializes Degree type
        /// </summary>
        public Degree()
        {
            Default();
        }

        /// <summary>
        /// Initializes Degree type
        /// </summary>
        /// <param name="rad">Angle in degree unit</param>
        public Degree(double deg)
        {
            Default();
            value = deg;
            Validate();
        }

        /// <summary>
        /// Initializes Degree type
        /// </summary>
        /// <param name="rad">Angle in degree unit</param>
        /// <param name="angleConverter">Degree angle converter</param>
        public Degree(double deg, IAngleConverter angleConverter)
        {
            value = deg;
            AngleConverter = angleConverter;
            Validate();
        }

        /// <summary>
        /// Cast Radiant type to Degree type
        /// </summary>
        /// <param name="angle">Radiant</param>
        public static implicit operator Degree(Radiant angle)
        {
            DegreeConverter dc = new DegreeConverter();
            return new Degree(dc.Convert(angle));
        }

        protected override Angle Add(Angle angle)
        {
            return new Degree(this.Value + AngleConverter.Convert(angle));
        }

        protected override Angle Sub(Angle angle)
        {
            return new Degree(this.Value - AngleConverter.Convert(angle));
        }

        protected override Angle Mul(double mul)
        {
            return new Degree(this.Value * mul);
        }

        protected override Angle Div(double div)
        {
            return new Degree(this.Value / div);
        }

        protected override Angle Mod(double mod)
        {
            return new Degree(this.Value % mod);
        }

        protected override bool Lessthan(Angle angle)
        {
            return this.Value < AngleConverter.Convert(angle);
        }

        protected override bool GreaterThan(Angle angle)
        {
            return this.Value > AngleConverter.Convert(angle);
        }

        protected override bool Equal(Angle angle)
        {
            return this.Value == AngleConverter.Convert(angle);
        }

        protected override bool NotEqual(Angle angle)
        {
            return this.Value != AngleConverter.Convert(angle);
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
            if (value < 0 || value >= 360)
                new AngleOutOfRangeException("The degree is out of range", Value, 0, 360);
        }
    }
}
