using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingWithLINQ
{
    // Make a class for the demo
    class Customer
    {
        private int intID;
        private string strName;

        public int ID
        {
            get { return intID; }
            set { intID = value; }
        }
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        public Customer(int ID, string Name) { this.ID = ID; this.Name = Name; }
        public override string ToString() { return ID.ToString() + "," + Name; }
    }
}
