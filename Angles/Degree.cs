﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Angles.Converter;

namespace Angles
{
    public class Degree : Angle
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

        public Degree(double _deg, IAngleConverter angleConverter)
        {
            angle = _deg;
            AngleConverter = angleConverter;
        }

        public static implicit operator Degree(Radiant angle)
        {
            DegreeConverter dc = new DegreeConverter();
            return new Degree(dc.Convert(angle));
        }

        protected override Angle Add(Angle angle)
        {
            return new Degree(this.Metric + AngleConverter.Convert(angle));
        }
    }
}
