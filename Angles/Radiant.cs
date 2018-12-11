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
        /// <param name="dir">Direction of an angle</param>
        public Radiant(double rad, Direction dir)
        {
            Default();
            value = rad;
            direction = dir;
            Validate();
        }

        /// <summary>
        /// Initializes Radiant type
        /// </summary>
        /// <param name="rad">Angle in radiant unit</param>
        /// <param name="dir">Direction of an angle</param>
        /// <param name="angleConverter">Radiant angle converter</param>
        public Radiant(double rad, IAngleConverter angleConverter)
        {
            value = rad;
            AngleConverter = angleConverter;
            Validate();
        }

        /// <summary>
        /// Initializes Radiant type
        /// </summary>
        /// <param name="rad">Angle in radiant unit</param>
        /// <param name="angleConverter">Radiant angle converter</param>
        public Radiant(double rad, Direction dir, IAngleConverter angleConverter)
        {
            value = rad;
            direction = dir;
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

        public override double Sin()
        {
            return Math.Sin(Value);
        }

        public override double Cos()
        {
            return Math.Cos(Value);
        }

        public override double Tan()
        {
            return Math.Tan(value);
        }

        public override double ArcSin()
        {
            return 1.0 / Math.Sin(Value);
        }

        public override double ArcCos()
        {
            return 1.0 / Math.Cos(Value);
        }

        public override double ArcTan()
        {
            return 1.0 / Math.Tan(Value);
        }

        protected override void Validate()
        {
            if (value < 0 || value > 6.28)
                new AngleOutOfRangeException("The degree is out of range", Value, 0, 6.28);
        }
    }
}
