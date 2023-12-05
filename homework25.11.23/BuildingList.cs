using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework25._11._23
{
    public class BuildingList
    {
        public Building[] buildings = new Building[10];
        public Building this[int number]
        {
            get
            {
                if (number >= 0 || number < buildings.Length)
                    return buildings[number];
                else
                    throw new ArgumentOutOfRangeException("There is no building with that number.");
            }
            set
            {
                if (number >= 0 || number < buildings.Length)
                    buildings[number] = value;
            }
        }

    }
}
