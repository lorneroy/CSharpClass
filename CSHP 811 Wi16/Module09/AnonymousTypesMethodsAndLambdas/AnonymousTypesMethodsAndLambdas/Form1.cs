using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnonymousTypesMethodsAndLambdas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Standard Types
        class Customer { public int ID; public string Name;} //This is a simple standard class
        private void buttonUsingStandardTypes_Click(object sender, EventArgs e)
        {
            Customer objC1 = new Customer();
            objC1.ID = 1;
            objC1.Name = "Bob Smith";
            Console.WriteLine("Customer ID {0} is {1}", objC1.ID, objC1.Name);
        }
        #endregion

        #region Anonymous Types
        private void buttonUsingAnnonymousTypes_Click(object sender, EventArgs e)
        {
            var objC2 = new { ID = 2, Name = "Sue Jones" }; //This is a simple anonymous class
            Console.WriteLine("Customer ID {0} is {1}", objC2.ID, objC2.Name);
        }
        #endregion

        #region Standard Methods
        // Determine whether an int is even
        private static bool IsEven(int number)
        {
            return (number % 2 == 0);
        } // end method IsEven

        // Determine whether an int is odd
        private static bool IsOdd(int number)
        {
            return (number % 2 == 1);
        } // end method IsOdd

        private void buttonUsingStandardMethods_Click(object sender, EventArgs e)
        {
            // You can execute a standard method in a number of ways. 
            // Some are more explicate then others...
            string strNumber = textBoxNumber.Text;
            bool blnAnswer = IsEven(int.Parse(strNumber));
            Console.WriteLine("Result: " + "IsEven? " + blnAnswer.ToString());

            //Or
            blnAnswer = IsEven(int.Parse(textBoxNumber.Text));
            Console.WriteLine("Result: " + "IsEven? " + blnAnswer.ToString());

            //Or
            Console.WriteLine("Result: " + "IsEven? " + IsEven(int.Parse(textBoxNumber.Text)).ToString());
        }


        #endregion

        #region Delegates

        delegate bool ValidateNumber(int number);

        private void buttonUsingDelegates_Click(object sender, EventArgs e)
        {
            // You can create a delegate variable and point it 
            // to a method with this syntax...
            ValidateNumber objMyDelegateVariable = new ValidateNumber(IsEven);

            // Or this simpler syntax...
            ValidateNumber objVN = IsEven;

            //You use the delegate variable like this...
            string strNumber = textBoxNumber.Text;
            bool blnAnswer = objVN(int.Parse(strNumber)); //<--- standard
            Console.WriteLine("Result: " + objVN.Method.Name + "?" + blnAnswer.ToString());

            //Or this...
            blnAnswer = objVN(int.Parse(textBoxNumber.Text));//<--- less code!
            Console.WriteLine("Result: " + objVN.Method.Name + "?" + blnAnswer.ToString());

            //Or this...
            Console.WriteLine("Result: " + objVN.Method.Name + "?" + objVN(int.Parse(textBoxNumber.Text)).ToString());//<--- even less code!

            // Yet, another way to use Delegates is as a Parameter (in the FilterNumbers method)....
            List<int> AllNumbers = new List<int>(new int[] { 1, 2, 3 });
            List<int> EvenNumbers = new List<int>();
            List<int> OddNumbers = new List<int>();
            foreach (int item in AllNumbers)
            {   //Look at the method on line 122 ( FilterNumbers ) !
                if (FilterNumbers(IsEven, item)) { EvenNumbers.Add(int.Parse(item.ToString())); }//<--- Call the IsEven method with a delegate parameter !
                if (FilterNumbers(IsOdd, item)) { OddNumbers.Add(int.Parse(item.ToString())); }//<--- Call the IsOdd method with a delegate parameter !
            }

            foreach (var item in EvenNumbers) Console.WriteLine("List of Even Numbers " + item.ToString());
            foreach (var item in EvenNumbers) Console.WriteLine("List of Even Numbers " + item.ToString());

            // Microsoft has even made (2) Generic Delegates to help with this use of delegates: "Action" and "Func"
            // Action, is used to point to methods WITHOUT return values
            // Func, is used to point to methods WITH return values
            foreach (int item in AllNumbers)
            {   //Look at the method on line 128 ( FilterNumbersGeneric )!
                if (FilterNumbersGeneric(IsEven, item)) { EvenNumbers.Add(int.Parse(item.ToString())); }//<--- Call the FilterNumbersGeneric method with the "Func" delegate parameter !
                if (FilterNumbersGeneric(IsOdd, item)) { OddNumbers.Add(int.Parse(item.ToString())); }//<--- Call the FilterNumbersGeneric method with the "Func" delegate parameter !
            }

            foreach (var item in EvenNumbers) Console.WriteLine("List of Even Numbers " + item.ToString());
            foreach (var item in EvenNumbers) Console.WriteLine("List of Even Numbers " + item.ToString());
        }

        //Since Delegates are a type, they can be used to define parameters.
        private bool FilterNumbers(ValidateNumber FilterMethod, int Number)
        {
            return (FilterMethod(Number));
        }

        //The Func<T parameter, T return> generic acts like an Anonymous delegate 
        private bool FilterNumbersGeneric(Func<int, bool> FilterMethod, int Number)
        {
            return (FilterMethod(Number));
        }

        #endregion

        #region Anonymous Methods

        // Determine whether an int is greater then Zero with a standard method..
        private static bool MoreThanZero(int Number) { return (Number > 0); }

        private void buttonUsingAnnonymousMethods_Click(object sender, EventArgs e)
        {
            // You execute a STANDARD method like this...
            Console.WriteLine("Result: " + "More than Zero? " + MoreThanZero(int.Parse(textBoxNumber.Text)).ToString());

            // You execute the DELEGATE version like this...
            ValidateNumber objVM = new ValidateNumber(MoreThanZero);//This is the ValidateNumber delegate pointing to a NAMED method 
            Console.WriteLine("Result: " + "More than Zero? " + objVM(int.Parse(textBoxNumber.Text)).ToString());

            //You execute the ANONYMOUS Method version like this...
            objVM = delegate(int Number) { return Number > 0; };//This is the delegate pointing to an ANONYMOUS method
            Console.WriteLine("Result: " + "More than Zero? " + objVM(int.Parse(textBoxNumber.Text)).ToString());
        }
        #endregion

        #region Lambdas
        // Determine whether an int is less then Zero with a standard method...
        private static bool LessThanZero(int Number) { return (Number < 0); }

        private void buttonUsingLambdas_Click(object sender, EventArgs e)
        {
            // You execute a STANDARD method like this...
            Console.WriteLine("Result: " + "More than Zero? " + LessThanZero(int.Parse(textBoxNumber.Text)).ToString());

            // You execute the DELEGATE version like this...
            ValidateNumber objVM = new ValidateNumber(LessThanZero);//This is the delegate pointing to a NAMED method
            Console.WriteLine("Result: " + "More than Zero? " + objVM(int.Parse(textBoxNumber.Text)).ToString());

            // You execute the ANONYMOUS Method version like this...
            objVM = delegate(int Number) { return Number > 0; };//This is the delegate pointing to an ANONYMOUS method
            Console.WriteLine("Result: " + "More than Zero? " + objVM(int.Parse(textBoxNumber.Text)).ToString());

            // You execute the LAMBDA Method version like this...
            //NOTE: The Lambda pattern is Parameters (goes into) => Execution Code
            objVM = (n => n > 0);
            Console.WriteLine("Result: " + "More than Zero? " + objVM(int.Parse(textBoxNumber.Text)).ToString());

            // And of course you can use Microsoft's GENERIC "Func" delegate type as well...
            Func<int, bool> objF = (n => n > 0);
            Console.WriteLine("Result: " + "More than Zero? " + objF(int.Parse(textBoxNumber.Text)).ToString());
        }
        #endregion

        #region Extension Methods
        //Extension Methods allow you to "extend" to functionality 
        // of an existing class without having to rewrite, update, the
        // class's original code.

        private void buttonExtentionMethods_Click(object sender, EventArgs e)
        {
            string strData = textBoxNumber.Text.ToString();

            //Using a standard method...
            Console.WriteLine("Is the text Numeric? " + IsNumeric(strData));

            //Using an Extended method...
            Console.WriteLine("Is the text Numeric? " + strData.IsNumericExtended());//This method is in another class, down at the bottom of this file!

        }

        //This is a STANDARD method that would be used for validation
        public bool IsNumeric(string TextNumber)
        {
            Single output;
            return float.TryParse(TextNumber, out output);
            //Note: The output contains the string converted to is single-precision floating-point number equivalent.
        }

        #endregion

    }// End of Form1 class!

    // Extension Methods must be placed in a Static class.
    // and that class cannot be nested within another class.
    static class MyExtensionMethods
    {
        // This is an EXTENSION Method. These Methods must be set as Static. 
        // The this keyword indicate we are extending Microsoft's string type
        public static bool IsNumericExtended(this string TextNumber)
        {
            Single output;
            return float.TryParse(TextNumber, out output);
        }
    }
}
