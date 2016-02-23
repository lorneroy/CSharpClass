using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceAndPolymorphismDemos
{
    public sealed class TemporaryEmployee : Employee
    {
        private DateTime dtEndDate;

        public DateTime EndDate
        {
            get { return dtEndDate; }
            set { dtEndDate = value; }
        }

         public TemporaryEmployee() : base()
        { }

        public TemporaryEmployee(int EmployeeId, string Name, DateTime DOB, Gender Gender, DateTime EndDate)
        :base(EmployeeId,Name, DOB, Gender) 
        {
           this.EndDate = EndDate;
          }

        public override sealed string GetData() //Sealed is not needed since we have sealed the class!
        {
            return base.GetData() + "," + EndDate.ToString(); 
        }


    }

    //This will not work since the parent class was sealed
   // class DemoSealedClasses : TemporaryEmployee  { }

}

