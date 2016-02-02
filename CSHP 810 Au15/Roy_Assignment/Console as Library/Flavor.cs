using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._0_Console_As_Library
{
    public enum Flavor { REGULAR, ORANGE, LEMON }
    public static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();

        static FlavorOps()
        {
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                Flavor flavorEnumeral;
                Enum.TryParse<Flavor>(flavorName, out flavorEnumeral);
                _allFlavors.Add(flavorEnumeral); 
            }
        }

        // method to convert a string value into an enumeral
        public static Flavor ToFlavor(string FlavorName)
        {
            Flavor result = Flavor.REGULAR;
            if (Enum.IsDefined(typeof(Flavor), FlavorName) &&
                Enum.TryParse<Flavor>(FlavorName, out result))
            {
                // OK
            }
            else
            {
                // what happens if the string won't convert to
                // a Flavor enumeral?
                throw new VENDBADFLAVORException("Unknown flavor ", FlavorName);
            }
            return result;
        }

        // property to return a List<Flavor> of all of the Varieties
        public static List<Flavor> AllFlavors
        {
            get
            {
                return _allFlavors;
            }
        }

    }
}