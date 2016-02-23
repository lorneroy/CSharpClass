using System;

namespace MyOOPDemo
{
    class Classroom : Room
    {
        #region constants
        #endregion

        #region fields

        private bool blnHasProjector;

        private bool blnHasWhiteboard;

        #endregion

        #region properties
        public bool HasProjector
        {
            get { return blnHasProjector; }
            set { blnHasProjector = value; }
        }

        public bool HasWhiteboard
        {
            get { return blnHasWhiteboard; }
            set { blnHasWhiteboard = value; }
        }

        #endregion

        #region constructors

        public Classroom(): base()
        {
            HasWhiteboard = false;
            HasProjector = false;
        }

        Classroom(string Number, float Width, float Size, int Outlets, bool HasProjector, bool HasWhiteboard)
            : base(Number, Width, Size, Outlets)
        {
            this.HasProjector = HasProjector;
            this.HasWhiteboard = HasWhiteboard;
        }

        #endregion

        #region methods

        public override string GetData()
        {
            return base.GetData() + "Has Whiteboard: " + HasWhiteboard.ToString(); ;
        }

        #endregion

    }
}
