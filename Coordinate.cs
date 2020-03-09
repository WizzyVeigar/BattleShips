namespace BattleShips
{
    public class Coordinate
    {
        private int xCoordinate;

        public int XCoordinate
        {
            get { return xCoordinate; }
            set { xCoordinate = value; }
        }

        private int yCoordinate;


        public int YCoordinate
        {
            get { return yCoordinate; }
            set { yCoordinate = value; }
        }

        public Coordinate(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }
    }
}