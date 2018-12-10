using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angles
{
    /// <summary>
    /// The exception is thrown when the angle is out of range with respective angular unit
    /// </summary>
    public class AngleOutOfRangeException : Exception
    {
        /// <summary>
        /// Actual value of angle
        /// </summary>
        public double Actual { get; set; }

        /// <summary>
        /// Mininum range
        /// </summary>
        public double Min { get; set; }

        /// <summary>
        /// Maximum range
        /// </summary>
        public double Max { get; set; }

        /// <summary>
        /// Initializes a new instance of the AngleOutOfRangeException with message
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception</param>
        public AngleOutOfRangeException(string message) 
            : base(message)
        {

        }

        /// <summary>
        /// Initializes new instance of the AngleOutOfRangeException with message, actual angular value and the range
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception</param>
        /// <param name="actual">Actual value of angle</param>
        /// <param name="min">Mininum value</param>
        /// <param name="max">Maxinum value</param>
        public AngleOutOfRangeException(string message, double actual, double min, double max) 
            : base(message)
        {
            Actual = actual;
            Min = min;
            Max = max;
        }

    }
}
