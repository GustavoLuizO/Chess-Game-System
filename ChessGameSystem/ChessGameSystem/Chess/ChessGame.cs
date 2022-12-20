using ChessGameSystem.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameSystem.Chess
{
    public class ChessGame
    {
        public ChessBoard ChessBoard { get;}
        private int Turno { get; set; }
        private Color CurrentPlayer { get; set; }
        public bool Finished { get; }

        public ChessGame()
        {
            ChessBoard = new ChessBoard(8, 8);
            Turno = 1;
            CurrentPlayer = Color.White;
            PutAllPieces();
        }

        public void ExecuteMovement(Position origin, Position destination)
        {
            ChessPiece piece = ChessBoard.RemovePiece(origin);
            piece.IncriminateMovements();
            
            ChessPiece capturedPiece= ChessBoard.RemovePiece(destination);
            ChessBoard.PutPiece(piece, destination);
        }

        private void PutAllPieces()
        {
            ChessBoard.PutPiece(new Tower(Color.White, ChessBoard), new PositionChess('c', 1).ToPosition());
            ChessBoard.PutPiece(new Tower(Color.White, ChessBoard), new PositionChess('c', 2).ToPosition());
            ChessBoard.PutPiece(new Tower(Color.White, ChessBoard), new PositionChess('d', 2).ToPosition());
            ChessBoard.PutPiece(new Tower(Color.White, ChessBoard), new PositionChess('e', 2).ToPosition());
            ChessBoard.PutPiece(new Tower(Color.White, ChessBoard), new PositionChess('e', 1).ToPosition());
            ChessBoard.PutPiece(new King(Color.White, ChessBoard), new PositionChess('d', 1).ToPosition());

            ChessBoard.PutPiece(new Tower(Color.Black, ChessBoard), new PositionChess('c', 7).ToPosition());
            ChessBoard.PutPiece(new Tower(Color.Black, ChessBoard), new PositionChess('c', 8).ToPosition());
            ChessBoard.PutPiece(new Tower(Color.Black, ChessBoard), new PositionChess('d', 7).ToPosition());
            ChessBoard.PutPiece(new Tower(Color.Black, ChessBoard), new PositionChess('e', 7).ToPosition());
            ChessBoard.PutPiece(new Tower(Color.Black, ChessBoard), new PositionChess('e', 8).ToPosition());
            ChessBoard.PutPiece(new King(Color.Black, ChessBoard), new PositionChess('d', 8).ToPosition());
        }

    }
}
