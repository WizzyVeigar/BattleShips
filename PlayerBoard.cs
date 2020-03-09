using System;

namespace BattleShips
{
    public class PlayerBoard
    {
        private Field[,] board;

        public Field[,] Board
        {
            get { return board; }
            set { board = value; }
        }

        private int boardSize;

        public int BoardSize
        {
            get { return boardSize; }
            set { boardSize = value; }
        }
        

        public void CheckForSpace(Coordinate coordinateToCheck)
        {
            foreach (Field field in Board)
            {
                if(field.XCoordinate == coordinateToCheck.XCoordinate && field.YCoordinate == coordinateToCheck.YCoordinate)
                {
                    switch (field.CurrentState)
                    {
                        case FieldState.EMPTY:
                            //Call miss event
                            break;
                        case FieldState.SHOT:
                            //call already hit event
                            break;
                        case FieldState.SHIP:
                            //Call hit event
                            //Change state to Shot
                            break;
                    }
                }
            }
        }

        private bool CheckForValidMove()
        {
            return true;
        }

        public PlayerBoard(int size)
        {
            Board = new Field[size, size];
            BoardSize = size;
            FillBoard();
        }

        private void FillBoard()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = new Field(i, j);
                }

            }
        }
    }
}