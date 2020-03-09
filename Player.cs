using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Player
    {      
        private List<Ship> ships = new List<Ship>();
        public List<Ship> Ships
        {
            get { return ships; }
            set { ships = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private PlayerBoard pBoard = new PlayerBoard(10);

        public PlayerBoard PBoard
        {
            get { return pBoard; }
            set { pBoard = value; }
        }

        public void PlaceShip(Ship shipToPlace, Coordinate coordinate)
        {
            //PBoard.Board[coordinate.XCoordinate, coordinate.YCoordinate]
        }
        //public void Shoot(Coordinate placeToShoot)
        //{
            
        //}
    }
}
