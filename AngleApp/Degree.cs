using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleApp
{
    public class Degree : Angle, IAngleOperations
    {
        public Degree()
        {
            this.AngluarUnit = AngluarUnit.Degree;
        }

        public Angle Add(Angle angle)
        {
            throw new NotImplementedException();
        }
    }
}
