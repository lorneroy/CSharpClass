using System;

namespace ClassLibrarySnacks
{
    class HealthFood:Snack
    {
        #region constants
        #endregion

        #region fields

        private DateTime _freshUntil;

        #endregion

        #region properties

        public DateTime FreshUntil
        {
            get { return _freshUntil; }
            set { _freshUntil = value; }
        }


        #endregion

        #region constructors

        public HealthFood(string name, decimal price, DateTime freshUntil):base(name,price)
        {
            FreshUntil = freshUntil;
        }
        #endregion

        #region methods

        public override string ToString()
        {
            return String.Format("{0}Category: Health Food" + Environment.NewLine + "Fresh Until:" + FreshUntil.ToShortDateString() + Environment.NewLine, base.ToString());
        }

        #endregion

    }
}
