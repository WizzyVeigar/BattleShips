namespace BattleShips
{
    public enum FieldState
    {
        EMPTY,
        SHOT,
        SHIP
    }

    public class Field : Coordinate
    {
        private FieldState currentState;


        public FieldState CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        public Field(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate)
        {
            CurrentState = FieldState.EMPTY;
        }
    }
}