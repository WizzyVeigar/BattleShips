using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Ship
    {
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        private string shipName;


        public string ShipName
        {
            get { return shipName; }
            set { shipName = value; }
        }
        public Ship(int length, string shipName)
        {
            Length = length;
            ShipName = shipName;
        }

    }
}
