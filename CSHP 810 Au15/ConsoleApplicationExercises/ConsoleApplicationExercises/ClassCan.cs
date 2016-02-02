using System;

namespace ConsoleApplicationExercises
{
    class Can
    {
        #region constants
        #endregion

        #region fields
        #endregion

        #region properties
        
        public readonly Flavor TheFlavor = Flavor.REGULAR;

        #endregion

        #region constructors

        public Can()
        {

        }
        public Can(Flavor AFlavor) 
        { 
            TheFlavor = AFlavor; 
        }

        #endregion

        #region methods
        #endregion

    }

    public enum Flavor { REGULAR, ORANGE, LEMON }

}
