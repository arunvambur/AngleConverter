using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleApp
{
    public class Radiant : Angle, IAngleOperations
    {
        public Radiant()
        {
            this.AngluarUnit = AngluarUnit.Radiant;
        }
        public Angle Add(Angle angle)
        {
            throw new NotImplementedException();
        }
    }
}
