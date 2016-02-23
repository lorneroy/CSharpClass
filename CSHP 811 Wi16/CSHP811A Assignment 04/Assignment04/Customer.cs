using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment04
{
    class Customer:Person 
    {
       private int intCustomerId;

        public int CustomerId
        {
            get { return intCustomerId; }
            set { intCustomerId = value; }
        }

        public override string GetData() //Using the New keyword forces an override!
        {
           return CustomerId.ToString() + "," + base.GetData();
        }
        
    }
}
