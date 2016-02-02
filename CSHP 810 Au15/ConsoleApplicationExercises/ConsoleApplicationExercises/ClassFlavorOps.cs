using System;
using System.Collections.Generic;

namespace ConsoleApplicationExercises
{
    public static class FlavorOps
    {
        #region constants
        
        #endregion

        #region fields

        private static List<Flavor> _allFlavors;

        #endregion

        #region properties
        public static List<Flavor> AllFlavors
        {
            // property to return a List<Flavor> of all of the Varieties
            get 
            {
                return _allFlavors;
            }
        }
        #endregion

        #region constructors
        static FlavorOps() 
        {
            _allFlavors = new List<Flavor>((Flavor[])Enum.GetValues(typeof(Flavor)));
        
        }

        #endregion


        #region methods

        // method to convert a string value into an enumeral
        public static Flavor ToFlavor(string FlavorName)
        {
            Flavor result;

            if (Enum.IsDefined(typeof(Flavor),FlavorName))
            {
                result = (Flavor) Enum.Parse(typeof(Flavor), FlavorName);
            }
            else
            {
                throw new Exception("Undefined Flavor");
            }
            return result;
        }
        #endregion

    }
}
