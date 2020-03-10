namespace BattleShips
{
    public enum FieldState
    {
        EMPTY,
        SHOT,
        SHIP
    }

    public class Field
    {
        private FieldState currentState;

        public FieldState CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        private int coordinate;

        public int Coordinate
        {
            get { return coordinate; }
            set { coordinate = value; }
        }

        private string letter;

        public string Letter
        {
            get { return letter; }
            set { letter = value; }
        }


        public Field(int coordinate, string letter)
        {
            Coordinate = coordinate;
            Letter = letter;
            CurrentState = FieldState.EMPTY;
        }


        public string GetFieldName()
        {
            return letter + Coordinate;
        }
    }
}