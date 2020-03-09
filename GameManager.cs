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
        List<Player> players = new List<Player>();

        public void RunGame(Player p1, Player p2)
        {
            players.Add(p1);
            players.Add(p2);
        }




        public Button[] UpdateCoordinates()
        {

            //string boardState = "";

            //foreach (Player player in players)
            //{
            //    for (int i = 0; i < player.PBoard.Board.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < player.PBoard.Board.GetLength(1); j++)
            //        {
            //            switch (player.PBoard.Board[i,j].CurrentState)
            //            {
            //                case FieldState.EMPTY:
            //                    boardState += "O ";
            //                    break;
            //                case FieldState.SHOT:
            //                    boardState += "X ";
            //                    break;
            //                case FieldState.SHIP: boardState += "S ";
            //                    break;
            //                default:
            //                    break;
            //            }
            //        }
            //        boardState += "\n";
            //    }
            //}
            //    return boardState;
        }
    }
}
