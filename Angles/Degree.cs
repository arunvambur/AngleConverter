using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles
{
    public class Degree : Angle
    {
        public Degree(double _deg)
        {
            deg = _deg;
        }

        protected override Angle Add(Angle angle)
        {
            return new Degree(this.Deg + angle.Deg);
        }

        protected override Angle Convert(Angle angle)
        {
            if (angle is Degree) return angle;
            else if (angle is Radiant)
            {
                //return new Degree((180 / Math.PI) * angle.Rad);
                return new Degree(angle.ToDegree());
            }

            return null;
        }

        public override double ToDegree()
        {
            return deg;
        }

        public override double ToRadiant()
        {
            return (Math.PI / 180) * deg;
        }
    }
}
