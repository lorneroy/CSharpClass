using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01
{
    interface ICalculator
    {
        ///<summary>
        ///Add 
        ///</summary>
        ///<returns>
        ///Returns x added by y
        ///</returns>
        double Add(double x, double y);

        ///<summary>
        ///Subtract 
        ///</summary>
        ///<returns>
        ///Returns x subtracted by y
        ///</returns>
        double Subtract(double x, double y);

        ///<summary>
        ///Multiply 
        ///</summary>
        ///<returns>
        ///Returns x multiplied by y
        ///</returns>
        double Multiply(double x, double y);

        ///<summary>
        ///Divide 
        ///</summary>
        ///<returns>
        ///Returns x divided by y, null if y = 0
        ///</returns>
        double? Divide(double x, double y);
    }
}
