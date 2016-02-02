using System;

namespace ClassLibrarySnacks
{
    class CandyBar:JunkFood
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties
        #endregion

        #region constructors

        public CandyBar(string name, decimal price, int caloriesFromFat):base(name,price,caloriesFromFat)
        {

        }
        #endregion

        #region methods

        public override string ToString()
        {

            return String.Format("{0}Chewy!", base.ToString());
        }


        #endregion

    }
}
