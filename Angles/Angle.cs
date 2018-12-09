using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Angles.Converter;

namespace Angles
{
    public abstract class Angle
    {
        protected double angle;
        protected IAngleConverter AngleConverter { get; set; }

        public double Metric { get { return angle; } set { angle = value; } }

        private void PreValidate()
        {
            if (AngleConverter == null)
                throw new InvalidOperationException("No angle converter is initialized.");
        }

        public static Angle operator +(Angle op1, Angle op2)
        {
            op1.PreValidate();
            op2.PreValidate();

            return op1.Add(op2);
        }

        protected abstract Angle Add(Angle angle);

    }
}
