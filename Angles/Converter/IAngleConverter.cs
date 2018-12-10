using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles.Converter
{
    /// <summary>
    /// An interface for converting one angular unit to another unit
    /// </summary>
    public interface IAngleConverter
    {
        /// <summary>
        /// Convert one angular unit to another unit
        /// </summary>
        /// <param name="angle">angle need to be converted</param>
        /// <returns>Converted value in respective calling unit</returns>
        double Convert(Angle angle);
    }
}
