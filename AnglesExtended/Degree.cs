using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using AnglesExtended.Converter;

namespace AnglesExtended
{
    public class Degree : Angles.Degree
    {
        private void Default()
        {
            AngleConverter = new DegreeConverter();
        }

        public Degree()
        {
            Default();
        }

        public Degree(double _deg)
        {
            Default();
            angle = _deg;
        }

        public Degree(double _deg, Angles.Converter.IAngleConverter angleConverter)
        {
            angle = _deg;
            AngleConverter = angleConverter;
        }

        public static implicit operator Degree(Gradian angle)
        {
            DegreeConverter dc = new DegreeConverter();
            return new Degree(dc.Convert(angle));
        }

        public static implicit operator Degree(Angles.Radiant angle)
        {
            DegreeConverter dc = new DegreeConverter();
            return new Degree(dc.Convert(angle));
        }
    }
}
