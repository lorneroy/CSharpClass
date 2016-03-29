using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperatorOverloadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* "C# allows user-defined types to overload operators by defining 
         * static member functions using the operator keyword. 
         * Not all operators can be overloaded, however, 
         * and others have restrictions", http://msdn.microsoft.com/en-us/library/8edha89s(v=vs.80).aspx
         */ 

        //This is a new user-defined type that will include overloaded operators...
        private class TextColumn
        {
            private string _Value;
            public string Value
            {
                get { return _Value; }
                set { _Value = value; }
            }

            public TextColumn(string Value = "test")
            { this.Value = Value; }

            public override string ToString()
            { return Value; }

            // Declare that the operator (+) can add two TextColumn objects
            // and the return a new Column object
            public static TextColumn operator +(TextColumn c1, TextColumn c2)
            {
                return new TextColumn(c1.Value + c2.Value);
            }

            // Declare that the operator (==) can compare the value of two TextColumn objects
            // and return true or false
            public static bool operator ==(TextColumn c1, TextColumn c2)
            {
                bool IsSameValue = false;
                if (c1.Value == c2.Value)
                {
                    IsSameValue = true;
                }
                return IsSameValue;
            }

            // Some operators, like the equity operator, must be overloaded in pairs 
            // otherwise the complier will complain!
            public static bool operator !=(TextColumn c1, TextColumn c2)
            {
                bool IsSameDifferent = false;
                if (c1.Value != c2.Value)
                {
                    IsSameDifferent = true;
                }
                return IsSameDifferent;
            }

            // It will still complain if we do not overriding two other methods, So...
            /*
             * Warning	1 'OperatorOverloading.Form1.TextColumn' defines operator == or operator != 
             * but does not override Object.GetHashCode()	
             * 
             * Warning	2	'OperatorOverloading.Form1.TextColumn' defines operator == or operator != 
             * but does not override Object.Equals(object o)
             */

            //Always override GetHashCode(),Equals when overloading ==
            public override bool Equals(object obj)
            {
                // This works the same as if we used an (if) construct! 
                return this == (TextColumn)obj;
            }

            public override int GetHashCode()
            {
                //A hash code is a numeric value that is used to identify an object.
                //It can be used for equality testing. http://msdn.microsoft.com/en-us/library/system.object.gethashcode.aspx
                return Convert.ToInt32(Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Let's create a row of data using 3 TextColumn objects
            TextColumn ID = new TextColumn("1");
            TextColumn FirstName = new TextColumn("Bob");
            TextColumn LastName = new TextColumn("Smith");
            TextColumn[] arrRow1 = { ID, FirstName, LastName };

            //This is an alternate way of creating a row!
            TextColumn[] arrRow2 = { new TextColumn("1"), new TextColumn("Sue"), new TextColumn("Jones") };

            Console.WriteLine("Contents of the Row 1: {0},{1},{2}", arrRow1[0].ToString(), arrRow1[1].ToString(), arrRow1[2].ToString());
            Console.WriteLine("Contents of the Row 2: {0},{1},{2}", arrRow1[0].ToString(), arrRow1[1].ToString(), arrRow1[2].ToString());
            //Note that the ToString method of an array is not overloaded to reflect its contents

            //Now let see if the column objects are consider equal?
            if (arrRow1[0] == arrRow2[0])
            {
                Console.WriteLine("The are Equal");
            }
            else
            {
                Console.WriteLine("The are Different!");
            }
        }
    }
}
