using System;

namespace ClassLibrarySnacks
{
    class Banana : HealthFood
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties
        #endregion

        #region constructors

        public Banana(string name, decimal price, DateTime freshUntil):base(name,price,freshUntil)
        {

        }
        #endregion

        #region methods

        public override string ToString()
        {

            return String.Format("{0}Peel Me!", base.ToString());
        }

        #endregion

    }
}
