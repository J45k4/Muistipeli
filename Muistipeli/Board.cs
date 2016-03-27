using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace tictactoe
{
    /*
    /// <summary>
    /// Logical board class
    /// </summary>
    public class Board : IControl, IBoard
    {
        #region Board
        private System.Windows.Controls.Primitives.UniformGrid board; 
        #endregion
        #region game
        /// <summary>
        /// Board luokka sisältää pelin
        /// </summary>
        private Game game; 
        #endregion

        #region Board
        public Board(System.Windows.Controls.Primitives.UniformGrid board)
        {
            this.board = board;
            game = new TTTGame();
            Reset();
        } 
        #endregion

        #region initBoard
        /// <summary>
        /// initialized all the buttons in the GUI board
        /// </summary>
        public void initBoard()
        {
            board.Children.Clear();
            for (int i = 0; i < 9; i++)
            {
                Button b = new Button();
                b.FontSize = 40;
                this.board.Children.Add(b);
                b.Click += ButtonClick;
            }
        } 
        #endregion

        #region Reset
        /// <summary>
        /// Alustetaan board luokan olio ja samalla kutsutaan game olion Reset metodia
        /// </summary>
        public void Reset()
        {

            initBoard();
            game.Reset();
        } 
        #endregion

        #region Set
        /// <summary>
        /// Set metodi jolla kutsutaan game olion Set metodia
        /// </summary>
        public void Set(int i, int j, bool machine)
        {
            game.Set(i, j, machine);
        }

        public void Set(int i, bool machine)
        {
            Set(i / 3, i % 3, machine);
        }
        #endregion

        #region Close
        /// <summary>
        /// Tällä metodilla näytetään voittaja jonka jälkeen aloitetaan peli alusta Reset metodilla.
        /// </summary>
        private void Close(char winner)
        {
            if (winner == Marks.cross)
            {
                System.Windows.MessageBox.Show("Sinä voitit!");
            }
            else if (winner == Marks.naught)
            {
                System.Windows.MessageBox.Show("Tietokone voitti!");
            }
            else if (winner == Marks.empty)
            {
                System.Windows.MessageBox.Show("Tasapeli");
            }
            Reset();
        } 
        #endregion

        #region ButtonClick
        /// <summary>
        /// Button luokan Click eventin toteutus funktio jota käytetään pelin ohjaamiseen.
        /// </summary>

        private void ButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = Marks.cross;
            button.IsEnabled = false;
            Set(board.Children.IndexOf(button) / 3, board.Children.IndexOf(button) % 3, false);
            if (game.Check() == Marks.cross)
            {
                Close(Marks.cross);
            }
            else
            {
                TTTGame tttgame = (TTTGame)game;
                int move = tttgame.TryBestMoves();
                if (move > -1)
                {
                    Set(move / 3, move % 3, true);
                    button = (Button)board.Children[move];
                    button.Content = Marks.naught;
                    button.IsEnabled = false;
                    if (game.Check() == Marks.naught)
                    {
                        Close(Marks.naught);
                    }
                }
                else
                {
                    if (game.Check() == Marks.empty)
                    {
                        Close(Marks.empty);
                    }
                }

            }

        } 
        #endregion
    }*/
}
