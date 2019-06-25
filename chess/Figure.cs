using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    enum Figure
    {
        none,
        whiteKing = 'K',
        whiteQeen = 'Q',
        whiteRook = 'R',
        whiteBishop = 'B',
        whiteKnight = 'N',
        whitePaw = 'P',

        blackKing = 'k',
        blackQeen = 'q',
        blackRook = 'r',
        blackBishop = 'b',
        blackKnight = 'n',
        blackPaw = 'p',
    }

    static class FigureMethods
    {
        public static Color GetColor(this Figure figure)
        {
            if (figure == Figure.none)
                return Color.none;
            return (figure == Figure.whiteKing ||
                    figure == Figure.whiteQeen ||
                    figure == Figure.whiteRook ||
                    figure == Figure.whiteBishop ||
                    figure == Figure.whiteKnight ||
                    figure == Figure.whitePaw)
                    ? Color.white
                    : Color.black;
        }
    }
}
