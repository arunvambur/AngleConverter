using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Angles.Converter;

namespace Angles
{
    /// <summary>
    /// Abstract class for different types of angles(angular units)
    /// </summary>
    public abstract class Angle
    {
        protected double value;

        /// <summary>
        /// Converter to convert the angle between diffeent angular units
        /// </summary>
        protected IAngleConverter AngleConverter { get; set; }

        /// <summary>
        /// Value of angle
        /// </summary>
        public double Value { get { return value; } set { this.value = value; } }


        private void PreValidate()
        {
            if (AngleConverter == null)
                throw new InvalidOperationException("No angle converter is initialized.");
        }

        /// <summary>
        /// Force sub class to implement addition operation
        /// </summary>
        /// <param name="angle">Angle to be added</param>
        /// <returns></returns>
        protected abstract Angle Add(Angle angle);

        /// <summary>
        /// Force sub class to implement subtraction operation
        /// </summary>
        /// <param name="angle">Angle to be subtracted</param>
        /// <returns></returns>
        protected abstract Angle Sub(Angle angle);

        /// <summary>
        /// Force sub class to implement multiplication operation
        /// </summary>
        /// <param name="angle">Angle to be multiplied by</param>
        /// <returns></returns>
        protected abstract Angle Mul(double mul);

        /// <summary>
        /// Force sub class to implement division operation
        /// </summary>
        /// <param name="angle">Angle to be divided by</param>
        /// <returns></returns>
        protected abstract Angle Div(double div);

        /// <summary>
        /// Force sub class to implement modulo operation
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        protected abstract Angle Mod(double mod);

        /// <summary>
        /// Force sub class to implement less than operation
        /// </summary>
        /// <param name="angle">Angle on the right side</param>
        /// <returns></returns>
        protected abstract bool Lessthan(Angle angle);

        /// <summary>
        /// Force sub class to implement greater than operation
        /// </summary>
        /// <param name="angle">Angle on the right side </param>
        /// <returns></returns>
        protected abstract bool GreaterThan(Angle angle);

        /// <summary>
        /// Force sub class to implement equal operation
        /// </summary>
        /// <param name="angle">Angle on the right side</param>
        /// <returns></returns>
        protected abstract bool Equal(Angle angle);

        /// <summary>
        /// Force sub class to implement not equal operation
        /// </summary>
        /// <param name="angle">Angle on the right side</param>
        /// <returns></returns>
        protected abstract bool NotEqual(Angle angle);

        /// <summary>
        /// Trignometric function Sine
        /// </summary>
        /// <returns></returns>
        protected abstract double Sin();

        /// <summary>
        /// Trignometric function cosine
        /// </summary>
        /// <returns></returns>
        protected abstract double Cos();

        /// <summary>
        /// Trignometric function Tan
        /// </summary>
        /// <returns></returns>
        protected abstract double Tan();

        /// <summary>
        /// Trignometric function inverse Sine
        /// </summary>
        /// <returns></returns>
        protected abstract double ArcSin();

        /// <summary>
        /// Trignometric function inverse cosine
        /// </summary>
        /// <returns></returns>
        protected abstract double ArcCos();

        /// <summary>
        /// Trignometric function inverse tan
        /// </summary>
        /// <returns></returns>
        protected abstract double ArcTan();

        /// <summary>
        /// Forces the Unit class to validate the metric is within the respective range
        /// </summary>
        protected abstract void Validate();

        /// <summary>
        /// Addition of two angles
        /// </summary>
        /// <param name="op1">Left operand</param>
        /// <param name="op2">Right operand</param>
        /// <returns>New Angle with both angles added</returns>
        public static Angle operator +(Angle op1, Angle op2)
        {
            op1.PreValidate();
            op2.PreValidate();

            return op1.Add(op2);
        }

        /// <summary>
        /// Subtraction of two angles
        /// </summary>
        /// <param name="op1">Left operand</param>
        /// <param name="op2">Right operand</param>
        /// <returns>New Angle with both left angle subtracted from right angle</returns>
        public static Angle operator -(Angle op1, Angle op2)
        {
            op1.PreValidate();
            op2.PreValidate();

            return op1.Sub(op2);
        }

        /// <summary>
        /// Multiplication of two angles
        /// </summary>
        /// <param name="op1">Left operand</param>
        /// <param name="op2">Right operand</param>
        /// <returns>New Angle with both angles multiplied</returns>
        public static Angle operator *(Angle op1, double op2)
        {
            op1.PreValidate();

            return op1.Mul(op2);
        }

        /// <summary>
        /// Division of two angles
        /// </summary>
        /// <param name="op1">Left operand</param>
        /// <param name="op2">Right operand</param>
        /// <returns>New Angle with left angle dividedby right angle</returns>
        public static Angle operator /(Angle op1, double op2)
        {
            op1.PreValidate();

            return op1.Div(op2);
        }

        /// <summary>
        /// Modulo of two angles
        /// </summary>
        /// <param name="op1">Left operand</param>
        /// <param name="op2">Right operand</param>
        /// <returns>Mod of left angle with right angle</returns>
        public static Angle operator %(Angle op1, double op2)
        {
            op1.PreValidate();

            return op1.Mod(op2);
        }

        /// <summary>
        /// Less than operation
        /// </summary>
        /// <param name="op1">Left operand</param>
        /// <param name="op2">Right operand</param>
        /// <returns>True or False</returns>
        public static bool operator <(Angle op1, Angle op2)
        {
            op1.PreValidate();
            op2.PreValidate();

            return op1.Lessthan(op2);
        }

        /// <summary>
        /// Greater than operation
        /// </summary>
        /// <param name="op1">Left operand</param>
        /// <param name="op2">Right operand</param>
        /// <returns>True or False</returns>
        public static bool operator >(Angle op1, Angle op2)
        {
            op1.PreValidate();
            op2.PreValidate();

            return op1.GreaterThan(op2);
        }

        /// <summary>
        /// Equal operation
        /// </summary>
        /// <param name="op1">Left operand</param>
        /// <param name="op2">Right operand</param>
        /// <returns>True or False</returns>
        public static bool operator ==(Angle op1, Angle op2)
        {
            op1.PreValidate();
            op2.PreValidate();

            return op1.Equal(op2);
        }

        /// <summary>
        /// Not equal operation
        /// </summary>
        /// <param name="op1">Left operand</param>
        /// <param name="op2">Right operand</param>
        /// <returns>True or False</returns>
        public static bool operator !=(Angle op1, Angle op2)
        {
            op1.PreValidate();
            op2.PreValidate();

            return op1.NotEqual(op2);
        }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
    }
}
