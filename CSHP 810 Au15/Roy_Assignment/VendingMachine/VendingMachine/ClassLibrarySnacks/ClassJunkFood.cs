using System;

namespace ClassLibrarySnacks
{
    class JunkFood:Snack
    {
        #region constants
        #endregion

        #region fields

        private int _caloriesFromFat;

        #endregion

        #region properties

        public int CaloriesFromFat
        {
            get { return _caloriesFromFat; }
            set { _caloriesFromFat = value; }
        }


        #endregion

        #region constructors

        public JunkFood(string name, decimal price, int caloriesFromFat):base(name,price)
        {
            CaloriesFromFat = caloriesFromFat;
        }
        #endregion

        #region methods

        public override string ToString()
        {

            return String.Format("{0}Category: Junk Food" + Environment.NewLine + "Calories From Fat: {1}" + Environment.NewLine,base.ToString(), CaloriesFromFat);
        }

        #endregion

    }
}
