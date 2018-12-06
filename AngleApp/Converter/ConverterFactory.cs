using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleApp.Converter
{
    public static class ConverterFactory
    {
        public static IAngleConverter GetConverter(AngluarUnit unit)
        {
            switch(unit)
            {
                case AngluarUnit.Degree:
                    return  new DegreeConverter();

                case AngluarUnit.Radiant:
                    return new RadiantConverter();

                default:
                    return null;                    
                   
            }
        }
    }
}
