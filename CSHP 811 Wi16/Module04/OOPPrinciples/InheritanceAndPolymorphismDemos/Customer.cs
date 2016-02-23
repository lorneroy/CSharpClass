using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceAndPolymorphismDemos
{
    class Customer:Person 
    {
       private int intCustomerId;

        public int CustomerId
        {
            get { return intCustomerId; }
            set { intCustomerId = value; }
        }

        public new string GetData() //Using the New keyword forces an override!
        {
            //Won't work since these FIELDS are marked "private" : return CustomerId.ToString() + strName + dtDOB + enmGender.ToString();
            //return CustomerId.ToString() + Name + DOB + Gender.ToString();
           return CustomerId.ToString() + "," + base.GetData();
        }
        
    }
}
