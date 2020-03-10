using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BattleShips
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameManager gameManager;
        Button[] gridButtons;
        Player p1;
        Player p2;
        string fieldSelected;


        public MainWindow()
        {
            gameManager = new GameManager();
            gameManager.ChangeLabelEvent += GameManager_changeLabelEvent;
            InitializeComponent();
            p1 = new Player("Lars");
            p2 = new Player("Lars2");
            gameManager.players.Add(p1);
            gameManager.players.Add(p2);
            //gameManager.convertGridToBoard(btnGrid);
            FillGrid();
        }

        private void GameManager_changeLabelEvent(object sender, EventArgs e)
        {
            lblText.Content = sender.ToString();
        }


        private void btn_ConfirmAction(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(fieldSelected))
            {
                gameManager.players[gameManager.playerTurn].PlaceShip(fieldSelected);

                if (gameManager.playerTurn == gameManager.players.Count)
                {
                    gameManager.playerTurn = 0;
                }
                gameManager.playerTurn++;
            }
        }

        /// <summary>
        /// Stupid method :(
        /// </summary>
        private void FillGrid()
        {
            gridButtons = new Button[gameManager.players[0].Board.Length];

            for (int i = 0; i < gameManager.players[0].Board.GetLength(1); i++)
            {
                for (int j = 0; j < gameManager.players[0].Board.GetLength(0); j++)
                {
                    Button MyControl = new Button();
                    MyControl.Content = gameManager.players[0].Board[i, j].GetFieldName();
                    MyControl.Name = "Button" + gameManager.players[0].Board[i, j].GetFieldName();
                    MyControl.Tag = gameManager.players[0].Board[i, j].GetFieldName();
                    MyControl.Click += btn_ChangeState;

                    Grid.SetColumn(MyControl, j);
                    Grid.SetRow(MyControl, i);
                    gridButtons[i + j] = MyControl;

                    btnGrid.Children.Add(gridButtons[i + j]);
                }
            }
        }

        private void btn_ChangeState(object sender, RoutedEventArgs e)
        {
            fieldSelected = ((Button)sender).Tag.ToString();
        }
    }
}
