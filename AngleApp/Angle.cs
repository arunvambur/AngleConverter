using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AngleApp.Converter;

namespace AngleApp
{
    public abstract class Angle
    {
        public AngluarUnit AngluarUnit { get; set; }

        public static Angle operator+(Angle op1, Angle op2)
        {
            IAngleConverter converter = ConverterFactory.GetConverter(op1.AngluarUnit);

            Angle newAngle = converter.Convert(op1);            

            return ((IAngleOperations)op1).Add(newAngle);
        }

    }
}
