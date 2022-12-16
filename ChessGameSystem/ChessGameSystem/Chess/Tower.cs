using ChessGameSystem.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameSystem.Chess
{
    public class Tower : ChessPiece
    {
        public Tower(Color color, ChessBoard chessBoard) : base(color, chessBoard) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
