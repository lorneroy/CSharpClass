using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment04
{
    public abstract class Person
    {
        private string strName;
        private DateTime dtDOB;
        private Gender enmGender;
        protected int TestProtected;// can be used in the Child classes
        internal int TestInternal;// can be used anywhere in the assembly (exe or dll)
        protected internal int TestProtectedInternal; //can be used from either

        public event EventHandler NameChanged;

        public event EventHandler DOBChanged;

        public event EventHandler GenderChanged;
    
        public Person():this("", DateTime.Now, Gender.Female)
        {
            //Name = "";
            //DOB = DateTime.Now;
            //Gender = Gender.Female;          

            Console.WriteLine("This will be processed AFTER the 3 argument constructor");

           //NewMethod("", DateTime.Now, Gender.Female);
        }

        public Person(string Name, DateTime DOB, Gender Gender)
        {
            //NewMethod( Name,  DOB,  Gender); 
            this.Name = Name;
            this.dtDOB = DOB;
            this.Gender = Gender;
        }

        //Olde way of Chaining Constructors
        //private void NewMethod(string Name, DateTime DOB, Gender Gender)
        //{
        //    this.Name = Name;
        //    this.DOB = DateTime.Now;
        //    this.Gender = Gender.Female;
        //}

        public string Name
        {
            get
            {

                try
                {
                    if (string.IsNullOrEmpty(strName))
                    {
                        throw new Exception("Name has not be set to a value!");
                    }
                    return strName;
                }
                catch (Exception)
                {
                    throw;
                }

            }
            set
            {
                try
                {
                    foreach (char chrLetter in (string)value)
                    {
                        if (char.IsDigit(chrLetter))
                        {
                            throw new Exception("Numbers are not allowed in a name.");
                        }
                    }

                    strName = value;
                    if (NameChanged  != null)
                    {
                        NameChanged(this, new EventArgs());
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public DateTime DOB
        {
            get
            {
                return dtDOB;
            }
            set
            {

                try
                {
                    if (value > DateTime.Now)
                    {
                        throw new Exception("DOB cannot be in the future!");
                    }
                    dtDOB = value;
                    if (DOBChanged != null )
                    {
                        DOBChanged(this, new EventArgs());  
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }

        public Gender Gender
        {
            get
            {
                return enmGender;
            }
            set
            {
                enmGender = value;
                if (GenderChanged != null )
                {
                    GenderChanged(this, new EventArgs()); 
                }
            }
        }

        /// <summary>
        /// Returns all the data in a Person object
        /// </summary>
        public virtual string GetData()
        {
            return Name + "," + DOB.ToLongDateString() + "," + Gender.ToString(); 
        }
    }
}
