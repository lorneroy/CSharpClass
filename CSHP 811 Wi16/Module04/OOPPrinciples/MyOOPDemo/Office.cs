using System;

namespace MyOOPDemo
{
    class Office : Room
    {
        #region constants
        #endregion

        #region fields

        bool blnHasWindow;

        #endregion

        #region properties

        public bool HasWindow
        {
            get { return blnHasWindow; }
            set { blnHasWindow = value; }
        }


        #endregion

        #region constructors

        public Office():base()
        {
            HasWindow = false;

        }

        Office(string Number, float Width, float Size, int Outlets, bool HasWindow):base(Number, Width, Size, Outlets)
        {
            this.HasWindow = HasWindow;

        }

        #endregion

        #region methods

        public override string GetData()
        {
            return base.GetData()+ "Has Window: "+HasWindow.ToString();
        }

        #endregion

    }
}
