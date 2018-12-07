using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Angles
{
    public abstract class Angle
    {
        protected double angle;

        public double Metric { get { return angle; } set { angle = value; } }

        public static Angle operator +(Angle op1, Angle op2)
        {
            return op1.Add(op2);
        }

        public abstract double ToDegree();
        public abstract double ToRadiant();

        protected abstract Angle Add(Angle angle);

    }
}
