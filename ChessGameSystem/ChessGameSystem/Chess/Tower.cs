using ChessGameSystem.Tabuleiro;

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
