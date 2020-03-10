using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Player
    {
        private Field[,] board = new Field[10, 10];

        public Field[,] Board
        {
            get { return board; }
            set { board = value; }
        }

        private List<Ship> ships;
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

        public Player(string name)
        {
            Name = name;
            Ships = new List<Ship>()
            {
                    new Ship(2, "PatruljeBåd"),
                    new Ship(3, "Ubåd"),
                    new Ship(3, "Destroyer"),
                    new Ship(4, "Slagskib"),
                    new Ship(5, "HangarSkib")
            };

            FillBoard();
        }

        public void PlaceShip(string coordinate)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    CheckForSpace(coordinate, i, j);
                }
            }
        }
        //public void Shoot(Coordinate placeToShoot)
        //{

        //}

        public void CheckForSpace(string coordinateToCheck, int xCoordinate, int yCoordinate)
        {
            try
            {
                if (Board[xCoordinate, yCoordinate].GetFieldName() == coordinateToCheck)
                {

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool CheckForValidMove()
        {
            return true;
        }

        private void FillBoard()
        {
            for (int i = 0; i < Board.GetLength(1); i++)
            {
                for (int j = 0; j < Board.GetLength(0); j++)
                {
                    char temp = (char)(j + 97);
                    Board[i, j] = new Field(i, temp.ToString());
                }
            }
        }
    }
}
