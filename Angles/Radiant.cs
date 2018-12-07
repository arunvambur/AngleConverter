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
            rad = _rad;
        }

        protected override Angle Add(Angle angle)
        {
            return new Radiant(this.Rad + angle.Rad);
        }

        protected override Angle Convert(Angle angle)
        {
            return new Radiant(angle.ToRadiant());            
        }

        public override double ToDegree()
        {
            return (180 / Math.PI) * rad;
        }

        public override double ToRadiant()
        {
            return rad;
        }
    }
}
