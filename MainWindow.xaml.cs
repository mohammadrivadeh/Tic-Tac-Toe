
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        private Type[] Results;
        private bool Player1Turn;
        private bool GameEnd;

        public MainWindow()
        {
            InitializeComponent();

            newGame();
        }

        private void newGame()
        {
            Results = new Type[9];
            for (int i = 0; i < Results.Length; i++) Results[i] = Type.Free;
            Player1Turn = true;
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                button.Content = string.Empty;
                button.Background = Brushes.WhiteSmoke;
                button.Foreground = Brushes.Blue;

            });
            GameEnd = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (GameEnd)
            {
                newGame();
                return;
            }

            var button = (Button)sender;
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var Index = column + (row * 3);
            if (Results[Index] != Type.Free) return;

            Results[Index] = Player1Turn ? Type.X : Type.O;
            button.Content = Player1Turn ? "X" : "O";

            Player1Turn ^= true;

            if (!Player1Turn)
            {
                button.Foreground = Brushes.Red;
            }
            CheckWinner();
        }

        private void CheckWinner()
        {
            #region Row 0,1,2
            if (Results[0] != Type.Free && (Results[0] & Results[1] & Results[2]) == Results[0])
            {
                GameEnd = true;
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.Green;
            }
            if (Results[3] != Type.Free && (Results[3] & Results[4] & Results[5]) == Results[3])
            {
                GameEnd = true;
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.Green;
            }
            if (Results[6] != Type.Free && (Results[6] & Results[7] & Results[8]) == Results[6])
            {
                GameEnd = true;
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion
            #region Column 0,1,2

            if (Results[0] != Type.Free && (Results[0] & Results[3] & Results[6]) == Results[0])
            {
                GameEnd = true;
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;
            }
            if (Results[1] != Type.Free && (Results[1] & Results[4] & Results[7]) == Results[1])
            {
                GameEnd = true;
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;
            }
            if (Results[2] != Type.Free && (Results[2] & Results[5] & Results[8]) == Results[2])
            {
                GameEnd = true;
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion
            #region x (0,4,8) & (0,4,6)
            if (Results[0] != Type.Free && (Results[0] & Results[4] & Results[8]) == Results[0])
            {
                GameEnd = true;
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;
            }
            if (Results[2] != Type.Free && (Results[2] & Results[4] & Results[6]) == Results[2])
            {
                GameEnd = true;
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.Green;
            }
            #endregion
            #region Draw
            if (!Results.Any(result => result == Type.Free))
            {
                GameEnd = true;
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.Yellow;
                   


                });
                MessageBox.Show("Draw !!!!!!");
            };
            #endregion

        }
    }
}
