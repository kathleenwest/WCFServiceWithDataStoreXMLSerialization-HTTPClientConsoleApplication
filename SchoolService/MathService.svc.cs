using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SchoolService
{
    /// <summary>
    /// Implementation Details for Math Service Interface
    /// </summary>
    public class MathService : IMathService
    {
        /// <summary>
        /// Method: Add
        /// Adds two numbers (double) together
        /// value1 + value2
        /// </summary>
        /// <param name="value1">First value (double) in mathematical operation</param>
        /// <param name="value2">Second value (double) in mathematical operation</param>
        /// <returns>Result (double) of the method math operation</returns>
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        } // end of Add method

        /// <summary>
        /// Method: Divide
        /// Divides two numbers (double)
        /// value1 / value2
        /// </summary>
        /// <param name="value1">First value (double) in mathematical operation</param>
        /// <param name="value2">Second value (double) in mathematical operation</param>
        /// <returns>Result (double) of the method math operation</returns>
        public double Divide(double value1, double value2)
        {
            return value1 / value2;
        } // end of method Divide

        /// <summary>
        /// Method: Multiply
        /// Multiplies two numbers (double)
        /// value1 * value2
        /// </summary>
        /// <param name="value1">First value (double) in mathematical operation</param>
        /// <param name="value2">Second value (double) in mathematical operation</param>
        /// <returns>Result (double) of the method math operation</returns>
        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        } // end of method Multiply

        /// <summary>
        /// Method: Subtract
        /// Subtracts two numbers (double)
        /// value1 - value2
        /// </summary>
        /// <param name="value1">First value (double) in mathematical operation</param>
        /// <param name="value2">Second value (double) in mathematical operation</param>
        /// <returns>Result (double) of the method math operation</returns>
        public double Subtract(double value1, double value2)
        {
            return value1 - value2;
        } // end of method Subtract

        /// <summary>
        /// Method: CicrleArea
        /// Calculates Area of Circle (double)
        /// pi * radius * radius
        /// </summary>
        /// <param name="radius">radius (double) in mathematical operation</param>
        /// <returns>Result (double) of the method math operation</returns>
        public double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        } // end of method CircleArea

    } // end of class
}
