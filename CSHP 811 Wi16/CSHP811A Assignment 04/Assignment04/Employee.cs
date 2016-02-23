using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment04
{
    public class Employee : Person
    {
        private int intEmployeeId;
    
        public int EmployeeId
        {
            get
            {
                return intEmployeeId ;
            }
            set
            {
                intEmployeeId = value;
            }
        }

        public Employee() : base()
        { }
        public Employee(int EmployeeId, string Name, DateTime DOB, Gender Gender)
        :base(Name, DOB, Gender) 
        {
           this.EmployeeId = EmployeeId;
           // this.Name = Name; This is not needed since the base constructor will be 
            // passed the data in with  :base(Name, DOB, Gender) 
        }

        public override string GetData()
        {
            return EmployeeId.ToString() + "," + base.GetData(); 
        }
    }
}
