using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace Muistipeli
{
    /// <summary>
    /// Täällä säilytetään mitä merkkejä käytetään pelinappuloiden ilmaisemiseen
    /// </summary>
    public struct Marks
    {
        public const char cross = 'x'; //player
        public const char naught = '0'; //machine
        public const char empty = '\0';

    }
}