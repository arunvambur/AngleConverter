using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles
{
    public class Radiant : Angle
    {
        public Radiant(double _rad)
        {
            angle = _rad;
        }

        protected override Angle Add(Angle angle)
        {
            return new Radiant(this.angle + angle.ToRadiant());
        }

        public override double ToDegree()
        {
            return (180 / Math.PI) * angle;
        }

        public override double ToRadiant()
        {
            return angle;
        }
    }
}
