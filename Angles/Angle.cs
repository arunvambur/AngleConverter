using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Angles
{
    public abstract class Angle
    {
        protected double deg;
        protected double rad;

        //public double Deg { get { deg = this.Convert(this).deg; return deg; } set { deg = value; } }
        //public double Rad { get { rad = this.Convert(this).rad; return rad; } set { rad = value; } }

        public double Deg { get { return this.ToDegree(); } set { deg = value; } }
        public double Rad { get { return this.ToRadiant(); } set { rad = value; } }


        public static Angle operator +(Angle op1, Angle op2)
        {
            var newAngle = op1.Convert(op2);

            return op1.Add(newAngle);
        }

        protected abstract Angle Convert(Angle angle);
        public abstract double ToDegree();
        public abstract double ToRadiant();

        protected abstract Angle Add(Angle angle);

    }
}
