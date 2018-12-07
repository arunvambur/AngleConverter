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
            angle = _deg;
        }

        protected override Angle Add(Angle angle)
        {
            return new Degree(this.Metric + angle.ToDegree());
        }

        public override double ToDegree()
        {
            return angle;
        }

        public override double ToRadiant()
        {
            return (Math.PI / 180) * angle;
        }
    }
}
