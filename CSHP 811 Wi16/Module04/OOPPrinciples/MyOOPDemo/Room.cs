using System;

namespace MyOOPDemo
{
    abstract class Room:IRoom
    {
        #region constants
        #endregion

        #region fields

        private string strNumber;
        private int intOutlets;
        private float fltWidth;
        private float fltSize;


        #endregion

        #region properties

        public string Number
        {
            get
            {
                return strNumber;
            }
            set
            {
                strNumber = value;
            }
        }

        public int Outlets
        {
            get
            {
                return intOutlets;
            }
            set
            {
                intOutlets = value;
            }
        }

        public float Size
        {
            get
            {
                return fltSize;
            }
            set
            {
                fltSize = value;
            }
        }

        public float Width
        {
            get
            {
                return fltWidth;
            }
            set
            {
                fltWidth = value;
            }
        }

        #endregion

        #region constructors

        public Room()
        {

        }

        public Room(string Number, float Width, float Size, int Outlets)
        {
            this.Number = Number;
            this.Width = Width;
            this.Size = Size;
            this.Outlets = Outlets;
        }

        #endregion

        #region methods

        public virtual string GetData()
        {
            return "Number: "+Number+ " Width: " +Width.ToString() + " Size: "+Size.ToString()+ " Outlets: "+Outlets.ToString();
        }

        #endregion

    }
}
