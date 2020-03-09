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

        public MainWindow()
        {
            gameManager = new GameManager();
            InitializeComponent();

            Binding gridBinding = new Binding();
            //gridBinding.Source = UpdateCoordinates();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player p1 = new Player();
            Player p2 = new Player();

            gameManager.RunGame(p1, p2);
            UpdateCoordinates();
        }

        /// <summary>
        /// Stupid method :(
        /// </summary>
        private void UpdateCoordinates()
        {
            int count = 1;

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Button MyControl = new Button();
                    MyControl.Content = count.ToString();
                    MyControl.Name = "Button" + count.ToString();

                    Grid.SetColumn(MyControl, j);
                    Grid.SetRow(MyControl, i);
                    btnGrid.Children.Add(MyControl);

                    count++;
                }

            }
        }
    }
}
