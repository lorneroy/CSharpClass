using System;

namespace ClassLibrarySnacks
{
    class PotatoChips: JunkFood
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties
        #endregion

        #region constructors

        public PotatoChips(string name, decimal price, int caloriesFromFat)
            : base(name, price, caloriesFromFat)
        {

        }
        #endregion

        #region methods

        public override string ToString()
        {

            return String.Format("{0}Crunchy!", base.ToString());
        }

        #endregion

    }
}
