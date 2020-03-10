using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShips
{
    class GameManager
    {
        public List<Player> players = new List<Player>();
        public event EventHandler ChangeLabelEvent;
        public byte playerTurn = 0;
        public bool placingShip = false;
        bool gameWon = false;


        //public void RunGame(Player p1, Player p2)
        //{
        //    byte turnCounter = 0;

        //    foreach (Player player in players)
        //    {
        //        SetupBoard(player);
        //    }

        //    //while (!gameWon)
        //    //{
        //    //    //foreach (Player player in players)
        //    //    //{
        //    //    //    //player.Shoot(); //Shoot at coordinate

        //    //    //    turnCounter++;
        //    //    //}
        //    //}
        //}

        private void SetupBoard(Player player)
        {
            for (int i = 0; i < player.Board.GetLength(0); i++)
            {

            }

            //for (int i = 0; i < player.Ships.Count; i++)
            //{
            //    changeLabelEvent("Place your " + player.Ships[i].ShipName, new EventArgs());
            //    placingShip = true;
            //}
        }

        /// <summary>
        /// Should be somewhere else
        /// </summary>
        //public void convertGridToBoard(System.Windows.Controls.Grid btnGrid)
        //{
        //    for (int i = 0; i < players.Count; i++)
        //    {
        //        for (int j = 0; j < players[i].Board.GetLength(0); j++)
        //        {
        //            for (int k = 0; k < players[i].Board.GetLength(1); k++)
        //            {
        //                foreach (Button button in btnGrid.Children)
        //                {
        //                    if (players[i].Board[j, k].GetFieldName() == button.Tag.ToString())
        //                    {

        //                    }
        //                }

        //            }
        //        }
        //    }            
        //}


        


        //public Button[] UpdateCoordinates()
        //{

        //    //string boardState = "";

        //    //foreach (Player player in players)
        //    //{
        //    //    for (int i = 0; i < player.PBoard.Board.GetLength(0); i++)
        //    //    {
        //    //        for (int j = 0; j < player.PBoard.Board.GetLength(1); j++)
        //    //        {
        //    //            switch (player.PBoard.Board[i,j].CurrentState)
        //    //            {
        //    //                case FieldState.EMPTY:
        //    //                    boardState += "O ";
        //    //                    break;
        //    //                case FieldState.SHOT:
        //    //                    boardState += "X ";
        //    //                    break;
        //    //                case FieldState.SHIP: boardState += "S ";
        //    //                    break;
        //    //                default:
        //    //                    break;
        //    //            }
        //    //        }
        //    //        boardState += "\n";
        //    //    }
        //    //}
        //    //    return boardState;
        //}
    }
}
