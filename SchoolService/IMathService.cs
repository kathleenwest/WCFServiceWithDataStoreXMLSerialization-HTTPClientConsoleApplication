using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SchoolService
{
    /// <summary>
    /// Interface for Math Service Methods
    /// Add, Subtract, Multiply, and Divide 
    /// Calculate Area of Circle
    /// </summary>
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        double Add(double value1, double value2);

        [OperationContract]
        double Subtract(double value1, double value2);

        [OperationContract]
        double Multiply(double value1, double value2);

        [OperationContract]
        double Divide(double value1, double value2);

        [OperationContract]
        double CircleArea(double radius);
    } // end of interface
}
