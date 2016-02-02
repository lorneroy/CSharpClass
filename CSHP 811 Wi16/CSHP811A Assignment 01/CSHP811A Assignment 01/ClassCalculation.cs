using System;

namespace CSHP811A_Assignment_01
{
    /// <summary>
    /// This class provides methods for calculating the 
    /// sum, difference, product, or quotient of two numbers
    /// </summary>
    static class Calculation
    {
        #region methods

        public static decimal add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public static decimal subtract(decimal number1, decimal number2)
        {
            return number1 - number2;
        }

        public static decimal multiply(decimal number1, decimal number2)
        {
            return number1 * number2;
        }

        public static decimal divide(decimal number1, decimal number2)
        {
            return number1 / number2;
        }

        #endregion

    }
}
