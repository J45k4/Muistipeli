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
using System.Threading;

namespace Muistipeli
{
    /// <summary>
    /// Interaction logic for BoarUi.xaml
    /// </summary>
    public partial class GridBoard : Page 
    {
        Game game;
        int size;
        int foundPairs = 0;

        int firstmove = -1;
        int secondmove = -1;
        public GridBoard(int size, Game game)
        {
            InitializeComponent();
            this.game = game;
            Init_board(size);
        }

        public void Init_board(int size)
        {
            this.size = size;
            for (int i = 0; i < size* size; i++)
            {
                Button b = new Button();
                b.FontSize = 40;
                b.Click += B_Click;
                board.Children.Add(b);
            }
            game.Reset(size);
        }

        public void Reset()
        {
            firstmove = -1;
            secondmove = -1;
            foundPairs = 0;
            for (int i = 0; i < size * size; i++)
            {
                Button b = (Button)board.Children[i];
                b.Content = Marks.empty;
                b.IsEnabled = true;
            }
            game.Reset(size);
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            if (firstmove > -1 && secondmove > -1)
            {
                if (game.Get(firstmove).Id != game.Get(secondmove).Id)
                {
                    //Thread.Sleep(2000);
                    Button but = (Button)board.Children[firstmove];
                    but.Content = Marks.empty;
                    but = (Button)board.Children[secondmove];
                    but.Content = Marks.empty;
                    //b.Click -= B_Click;
                }
                firstmove = -1;
                secondmove = -1;
            }
                Button b = (Button)sender;
            int i = board.Children.IndexOf(b);
            b.Content = game.Get(i).Content;
            if (firstmove < 0) firstmove = i;
            else if (secondmove < 0) secondmove = i;
            if (firstmove > -1 && secondmove > -1)
            {
                //MessageBox.Show(game.Get(firstmove).Id + ":" + game.Get(secondmove).Id);
                if (game.Get(firstmove).Id == game.Get(secondmove).Id)
                {
                    Button but = (Button)board.Children[firstmove];
                    but.IsEnabled = false;
                    but = (Button)board.Children[secondmove];
                    but.IsEnabled = false;
                    foundPairs++;
                    firstmove = -1;
                    secondmove = -1;
                }                 
                if (foundPairs >= size*size/2)
                {
                    MessageBox.Show("Löysit kaikki merkit");
                    Reset();
                }
            }
        }
    }
}
