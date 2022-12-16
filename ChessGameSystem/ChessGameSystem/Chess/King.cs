using ChessGameSystem.Tabuleiro;

namespace ChessGameSystem.Chess
{
    public class King : ChessPiece
    {
        public King(Color color, ChessBoard chessBoard) : base(color, chessBoard) { }

        public override string ToString()
        {
            return "K";
        }
    }
}
