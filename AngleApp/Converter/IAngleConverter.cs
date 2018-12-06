using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleApp.Converter
{
    public interface IAngleConverter
    {
        Angle Convert(Angle angle);
    }
}
