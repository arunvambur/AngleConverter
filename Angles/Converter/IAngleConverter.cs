using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles.Converter
{
    public interface IAngleConverter
    {
        double Convert(Angle angle);
        //T Convert<T>(Angle angle) where T : Angle;
    }
}
