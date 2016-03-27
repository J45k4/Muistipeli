using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Muistipeli
{
    /// <summary>
    /// Yleinen luokka peleille joka sisältää kenttiä ja metodeja joita voidaan mahdollisesti muissa lautapeleissä.
    /// </summary>
    public abstract class Game : IControl
    {
        #region content
        /// <summary>
        /// Sisältää pelilaudan sisällön
        /// </summary>
        protected Mark[,] content; 
        #endregion
        #region moves
        /// <summary>
        /// Kertoo tehtyjen siirtojen määrän
        /// </summary>
        protected int moves; 
        #endregion

        #region Moves
        public int Moves
        {
            get
            {
                return moves;
            }
        } 
        #endregion

        #region Reset
        /// <summary>
        /// Tyhjennetään pelaaja merkki taulukko ja asetetaan kuluneet siirrot nollaksi.
        /// </summary>
        public virtual void Reset(int size)
        {
            content = new Mark[size, size];
            moves = 0;
            for (int i = 0; i < content.GetLength(0); i++)
            {
                for (int j = 0; j < content.GetLength(1); j++)
                {
                    //content[i, j] = Mark.Empty;
                }
            }
        } 
        #endregion

        #region Set
        /// <summary>
        /// Asetetaan pelaajan merkki content taulukkoon.
        /// </summary>
        public void Set(int i, int j, Mark mark)
        {
            moves++;
        }

        public void Set(int i, Mark mark)
        {

        }

        #endregion

        #region Check
        public abstract Mark Check();

        #endregion

        public Mark Get(int i)
        {
            return content[i/content.GetLength(1), i%content.GetLength(1)];
        }
    }
}
