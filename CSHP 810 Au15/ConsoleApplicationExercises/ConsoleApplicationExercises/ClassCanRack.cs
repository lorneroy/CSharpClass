/*
 * Name: Lorne Roy
 * Student ID: 0034514 
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApplicationExercises
{

    /// <summary>
    /// This class will represent a can storage rack of the vending machine. 
    /// A can of soda will simply be represented as a number(e.g., orangeCans = 1 means there is one can of orange soda in the rack).
    /// </summary>
    class CanRack
    {
        #region constants

        public static int maxCans = 10;

        #endregion

        #region fields
        
        private Dictionary<Flavor, int> rack = null;

        #endregion

        #region properties


        #endregion

        #region constructors
        // Constructor for a can rack. The rack starts out full
        public CanRack() 
        {
            rack = new Dictionary<Flavor,int>();

            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                rack.Add(aFlavor, maxCans);

            }
        }

        #endregion

        #region methods

        /// <summary>
        /// this method finds the array index of the can bin from the flavor
        /// </summary>
        /// <param name="flavor">the flavor associated with the bin</param>
        /// <returns>the array index of the bin in the array</returns>

        public void DisplayCanRack()
        {
            foreach (KeyValuePair<Flavor, int> entry in rack)
            {
                Console.WriteLine("There are {0} cans of {1} soda remaining", entry.Value, entry.Key);
            }
        }

        //private int FlavorIndex(string flavor)
        //{
        //    Debug.WriteLine("Flavor index method called");
            
        //    int _index = -1;
            
        //    //foreach (CanBin bin in _canShelves
        //    for (int i = 0; i < _canShelves.Length; i++)
        //    {
        //        if (_canShelves[i].Flavor == flavor)
        //        {
        //            _index = i;
        //            break;
        //        }
        //    }

        //    Debug.WriteLine("The flavor index is " + _index);

        //    if (_index == -1)
        //    {
        //        throw new Exception("flavor not found");
        //    }

        //    return _index;
        //}


        //private int FlavorIndex(Flavor flavor)
        //{
        //    Debug.WriteLine("Flavor index method called");

        //    int _index = -1;

        //    //foreach (CanBin bin in _canShelves
        //    for (int i = 0; i < _canShelves.Length; i++)
        //    {
        //        if (_canShelves[i].Flavor == flavor.ToString())
        //        {
        //            _index = i;
        //            break;
        //        }
        //    }

        //    Debug.WriteLine("The flavor index is " + _index);

        //    if (_index == -1)
        //    {
        //        throw new Exception("flavor not found");
        //    }

        //    return _index;
        //}

        // This method adds a can of the specified flavor to the rack.

        public void AddACanOf(string FlavorOfCanToBeAdded) 
        {
            Debug.WriteLine("AddACanOf method called");
            //_canShelves[FlavorIndex(FlavorOfCanToBeAdded)].AddACan();
            AddACanOf(FlavorOps.ToFlavor(FlavorOfCanToBeAdded));
        }

        // This method adds a can of the specified flavor to the rack.
        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            Debug.WriteLine("AddACanOf method called");
            if (!IsFull(FlavorOfCanToBeAdded))
            {
                rack[FlavorOfCanToBeAdded] += 1;
            }
            else
            {
                throw new Exception("Shelf is full");
            }

        }


        // This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved) 
        {
            Debug.WriteLine("RemoveACanOf method called");
            RemoveACanOf(FlavorOps.ToFlavor(FlavorOfCanToBeRemoved));
        }

        // This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            Debug.WriteLine("RemoveACanOf method called");
            if (!IsEmpty(FlavorOfCanToBeRemoved))
            {
                rack[FlavorOfCanToBeRemoved] -= 1;
            }
            else
            {
                throw new Exception("Shelf is empty");
            }
        }


        // This method will fill the can rack.
        public void FillTheCanRack() 
        {
            Debug.WriteLine("FillTheCanRack method called");
            foreach (var entry in rack.Keys)
            {
                rack[entry] = maxCans;
            }
 
        }
        
        // This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied) 
        {
            Debug.WriteLine("EmptyCanRackOf method called");
            EmptyCanRackOf(FlavorOps.ToFlavor(FlavorOfBinToBeEmptied));
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            Debug.WriteLine("EmptyCanRackOf method called");
            rack[FlavorOfBinToBeEmptied] = 0;
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("IsFull method called");
            return IsFull(FlavorOps.ToFlavor(FlavorOfBinToCheck));

        }

        public Boolean IsFull(Flavor FlavorOfBinToCheck)
        {
            Debug.WriteLine("IsFull method called");

            if (rack[FlavorOfBinToCheck] == maxCans)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("IsEmpty method called");
            return IsEmpty(FlavorOps.ToFlavor(FlavorOfBinToCheck));
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            Debug.WriteLine("IsEmpty method called");

            if (rack[FlavorOfBinToCheck] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    } //end CanRack

}
