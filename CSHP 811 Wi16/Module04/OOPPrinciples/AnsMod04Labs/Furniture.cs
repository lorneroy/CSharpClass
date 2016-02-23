using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod04Labs
{
    public sealed class FurnitureSet : IFurnitureSet
    {
        List<Furniture> objFurnitureInSet = new List<Furniture>();
        int intChairCounter = 0, intTableCounter = 0;
        public FurnitureSet(int NumberOfChairs, int NumberOfTables)
        {
            while (NumberOfChairs > intChairCounter)
            { 
                objFurnitureInSet.Add(new Furniture(ItemTypes.chair));
                intChairCounter++;
            }
            
            while (NumberOfTables > intTableCounter)
            { 
                objFurnitureInSet.Add(new Furniture(ItemTypes.table));
                intTableCounter++;
            }
        }

        private enum ItemTypes {chair, table}
        private sealed class Furniture
        {
            private ItemTypes objItemType;
            public ItemTypes ItemType
            {
                get { return objItemType; }
                set { objItemType = value; }
            }
        public Furniture(ItemTypes Item)
        {ItemType = Item;}
        }
    }
}
