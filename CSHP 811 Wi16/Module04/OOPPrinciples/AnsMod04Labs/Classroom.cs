using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod04Labs
{
    public class Classroom : Room
    {
        FurnitureSet objRoomFurniture;

        public FurnitureSet RoomFurniture
        {
                        get
            {
                return objRoomFurniture;
            }
            set
            {
                objRoomFurniture = value;
            }
        }

    }
}
