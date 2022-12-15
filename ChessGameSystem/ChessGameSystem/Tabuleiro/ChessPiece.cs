using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameSystem.Tabuleiro
{
    public class ChessPiece
    {
        public Position Position { get; set; }
        public Color Color { get; set; }
        public int AmountMoves { get; set; }
        public ChessBoard ChessBoard { get; set; }

        public ChessPiece(Position position, Color color, ChessBoard chessBoard)
        {
            Position = position;
            Color = color;
            ChessBoard = chessBoard;
        }
    }
}
