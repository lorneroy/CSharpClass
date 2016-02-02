using System;

namespace ClassLibrarySnacks
{
    class Apple:HealthFood
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties
        #endregion

        #region constructors

        public Apple(string name, decimal price, DateTime freshUntil): base(name, price, freshUntil)
        {

        }
        #endregion

        #region methods
        public override string ToString()
        {

            return String.Format("{0}Rinse Me Off First!", base.ToString());
        }

        #endregion

    }
}
